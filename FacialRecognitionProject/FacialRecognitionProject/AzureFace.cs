//Import dependancies
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using Newtonsoft.Json;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using System.Windows.Forms;

namespace FacialRecognitionProject
{
    class AzureFace
    {
        const string SUBSCRIPTION_KEY = "SUB KEY GOES HERE";
        const string ENDPOINT = "END POINT GOES HERE";
        const string IMAGE_BASE_URL = "https://";
        static string personGroupId = Guid.NewGuid().ToString();

        public string CurrentPersonURL { get; set; }
        public string CurrentPersonName { get; set; }
        public string CurrentPersonDescription { get; set; }
        public string CurrentPersonImageName { get; set; }
        public string CurrentPersonID { get; set; }

        public class DataPerson
        {
            public int PersonID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int UserID { get; set; }
        }

        public class DataImages
        {
            public int ImageID { get; set; }
            public string ImageName { get; set; }
            public string ImageFile { get; set; }
            public int PersonID { get; set; }
        }

        public void AzureMain(string InputURL)
        {


            const string RECOGNITION_MODEL4 = RecognitionModel.Recognition04;

            // Authenticate.
            IFaceClient client = Authenticate(ENDPOINT, SUBSCRIPTION_KEY);

            // Detect - get features from faces.
            //DetectFaceExtract(client, IMAGE_BASE_URL, RECOGNITION_MODEL4).Wait();
            // Find Similar - find a similar face from a list of faces.
            FindSimilar(client, IMAGE_BASE_URL, RECOGNITION_MODEL4, InputURL).Wait();

            ReturnMethod();
        }

        /*
        *	AUTHENTICATE
        *	Uses subscription key and region to create a client.
        */
        public static IFaceClient Authenticate(string endpoint, string key)
        {
            return new FaceClient(new ApiKeyServiceClientCredentials(key)) { Endpoint = endpoint };
        }


        /* 
        * DETECT FACES
        * Detects features from faces and IDs them.
        */
        public static async Task DetectFaceExtract(IFaceClient client, string url, string recognitionModel)
        {
            MessageBox.Show("Detect Faces Method In Progress");

            // Create a list of images
            List<string> imageFileNames = new List<string>
                    {
                        "cdn.discordapp.com/attachments/751826556946743349/971129789438107658/20220420_213719.jpg"    
                    };

            foreach (var imageFileName in imageFileNames)
            {
                IList<DetectedFace> detectedFaces;

                // Detect faces with all attributes from image url.
                detectedFaces = await client.Face.DetectWithUrlAsync($"{url}{imageFileName}",
                        returnFaceAttributes: new List<FaceAttributeType> { 
                            FaceAttributeType.Accessories, 
                            FaceAttributeType.Age,
                            FaceAttributeType.Blur, 
                            FaceAttributeType.Emotion, 
                            FaceAttributeType.Exposure, 
                            FaceAttributeType.FacialHair,
                            FaceAttributeType.Glasses, 
                            FaceAttributeType.Hair, 
                            FaceAttributeType.HeadPose,
                            FaceAttributeType.Makeup, 
                            FaceAttributeType.Noise, 
                            FaceAttributeType.Occlusion, 
                            FaceAttributeType.Smile, 
                            FaceAttributeType.Gender },
                        // We specify detection model 1 because we are retrieving attributes.
                        detectionModel: DetectionModel.Detection01,
                        recognitionModel: recognitionModel);

                MessageBox.Show($"{detectedFaces.Count} face(s) detected from image `{imageFileName}`.");

                // Parse and print all attributes of each detected face.
                foreach (var face in detectedFaces)
                {
                    MessageBox.Show($"Face attributes for {imageFileName}:");

                    // Get bounding box of the faces
                    MessageBox.Show($"Rectangle(Left/Top/Width/Height) : {face.FaceRectangle.Left} {face.FaceRectangle.Top} {face.FaceRectangle.Width} {face.FaceRectangle.Height}");

                    // Get accessories of the faces
                    List<Accessory> accessoriesList = (List<Accessory>)face.FaceAttributes.Accessories;
                    int count = face.FaceAttributes.Accessories.Count;
                    string accessory; string[] accessoryArray = new string[count];
                    if (count == 0) { accessory = "NoAccessories"; }
                    else
                    {
                        for (int i = 0; i < count; ++i) { accessoryArray[i] = accessoriesList[i].Type.ToString(); }
                        accessory = string.Join(",", accessoryArray);
                    }
                    Console.WriteLine($"Accessories : {accessory}");

                    // Get face other attributes
                    MessageBox.Show($"Age : {face.FaceAttributes.Age}");
                    MessageBox.Show($"Blur : {face.FaceAttributes.Blur.BlurLevel}");

                    // Get emotion on the face
                    string emotionType = string.Empty;
                    double emotionValue = 0.0;
                    Emotion emotion = face.FaceAttributes.Emotion;
                    if (emotion.Anger > emotionValue) { emotionValue = emotion.Anger; emotionType = "Anger"; }
                    if (emotion.Contempt > emotionValue) { emotionValue = emotion.Contempt; emotionType = "Contempt"; }
                    if (emotion.Disgust > emotionValue) { emotionValue = emotion.Disgust; emotionType = "Disgust"; }
                    if (emotion.Fear > emotionValue) { emotionValue = emotion.Fear; emotionType = "Fear"; }
                    if (emotion.Happiness > emotionValue) { emotionValue = emotion.Happiness; emotionType = "Happiness"; }
                    if (emotion.Neutral > emotionValue) { emotionValue = emotion.Neutral; emotionType = "Neutral"; }
                    if (emotion.Sadness > emotionValue) { emotionValue = emotion.Sadness; emotionType = "Sadness"; }
                    if (emotion.Surprise > emotionValue) { emotionType = "Surprise"; }
                    MessageBox.Show($"Emotion : {emotionType}");

                    // Get more face attributes
                    MessageBox.Show($"Exposure : {face.FaceAttributes.Exposure.ExposureLevel}");
                    MessageBox.Show($"FacialHair : {string.Format("{0}", face.FaceAttributes.FacialHair.Moustache + face.FaceAttributes.FacialHair.Beard + face.FaceAttributes.FacialHair.Sideburns > 0 ? "Yes" : "No")}");
                    MessageBox.Show($"Glasses : {face.FaceAttributes.Glasses}");

                    // Get hair color
                    Hair hair = face.FaceAttributes.Hair;
                    string color = null;
                    if (hair.HairColor.Count == 0) { if (hair.Invisible) { color = "Invisible"; } else { color = "Bald"; } }
                    HairColorType returnColor = HairColorType.Unknown;
                    double maxConfidence = 0.0f;
                    foreach (HairColor hairColor in hair.HairColor)
                    {
                        if (hairColor.Confidence <= maxConfidence) { continue; }
                        maxConfidence = hairColor.Confidence; returnColor = hairColor.Color; color = returnColor.ToString();
                    }
                    MessageBox.Show($"Hair : {color}");

                    // Get more attributes
                    MessageBox.Show($"HeadPose : {string.Format("Pitch: {0}, Roll: {1}, Yaw: {2}", Math.Round(face.FaceAttributes.HeadPose.Pitch, 2), Math.Round(face.FaceAttributes.HeadPose.Roll, 2), Math.Round(face.FaceAttributes.HeadPose.Yaw, 2))}");
                    MessageBox.Show($"Makeup : {string.Format("{0}", (face.FaceAttributes.Makeup.EyeMakeup || face.FaceAttributes.Makeup.LipMakeup) ? "Yes" : "No")}");
                    MessageBox.Show($"Noise : {face.FaceAttributes.Noise.NoiseLevel}");
                    MessageBox.Show($"Occlusion : {string.Format("EyeOccluded: {0}", face.FaceAttributes.Occlusion.EyeOccluded ? "Yes" : "No")} " +
                        $" {string.Format("ForeheadOccluded: {0}", face.FaceAttributes.Occlusion.ForeheadOccluded ? "Yes" : "No")}   {string.Format("MouthOccluded: {0}", face.FaceAttributes.Occlusion.MouthOccluded ? "Yes" : "No")}");
                    MessageBox.Show($"Smile : {face.FaceAttributes.Smile}");

                }
            }
        }

        private static async Task<List<DetectedFace>> DetectFaceRecognize(IFaceClient faceClient, string url, string recognition_model)
        {
            // Detect faces from image URL. Since only recognizing, use the recognition model 1.
            // We use detection model 3 because we are not retrieving attributes.
            //MessageBox.Show("Beginning Detect Face Recognize");
            IList<DetectedFace> detectedFaces = await faceClient.Face.DetectWithUrlAsync(url, recognitionModel: recognition_model, detectionModel: DetectionModel.Detection03);
            List<DetectedFace> sufficientQualityFaces = new List<DetectedFace>();
            foreach (DetectedFace detectedFace in detectedFaces)
            {
                sufficientQualityFaces.Add(detectedFace);
            }
            //MessageBox.Show($"{detectedFaces.Count} face(s) with {sufficientQualityFaces.Count} having sufficient quality for recognition detected from image `{Path.GetFileName(url)}`");


            return sufficientQualityFaces.ToList();
        }

        /*
        * FIND SIMILAR
        * This example will take an image and find a similar one to it in another image.
        */

        static IList<Guid?> targetFaceIds = new List<Guid?>();
        static IList<SimilarFace> similarResults;
        static List<DataPerson> DBPeople;
        static List<DataImages> DBImages;
        public static async Task FindSimilar(IFaceClient client, string url, string recognition_model, string TargetInput)
        {
            MessageBox.Show("Find Similar Method In Progress");



            List<string> targetImageFileNames = new List<string>{};

            using (StreamReader r = new StreamReader("C:/Users/Alex/Desktop/COMP3000/DatabasePeopleReduced.json"))
            {
                string json = r.ReadToEnd();
                DBPeople = JsonConvert.DeserializeObject<List<DataPerson>>(json);
            }

            using (StreamReader r2 = new StreamReader("C:/Users/Alex/Desktop/COMP3000/DatabaseImagesReduced.json"))
            {
                string json = r2.ReadToEnd();
                DBImages = JsonConvert.DeserializeObject<List<DataImages>>(json);
            }

            foreach (DataImages item in DBImages)
            {
                targetImageFileNames.Add(item.ImageFile);
            }

            string sourceImageFileName = TargetInput;

            foreach (var targetImageFileName in targetImageFileNames)
            {
                // Detect faces from target image url.
                var faces = await DetectFaceRecognize(client, $"{url}{targetImageFileName}", recognition_model);
                // Add detected faceId to list of GUIDs.
                targetFaceIds.Add(faces[0].FaceId.Value);
            }

            // Detect faces from source image url.
            MessageBox.Show("Database Faces Identified");
            IList<DetectedFace> detectedFaces = await DetectFaceRecognize(client, $"{url}{sourceImageFileName}", recognition_model);
            MessageBox.Show("Face Detection Complete");

            // Find a similar face(s) in the list of IDs. Comapring only the first in list for testing purposes.
            similarResults = await client.Face.FindSimilarAsync(detectedFaces[0].FaceId.Value, null, null, targetFaceIds);

            foreach (var similarResult in similarResults)
            {
                MessageBox.Show($"Faces from {sourceImageFileName} & ID:{similarResult.FaceId} are similar with confidence: {similarResult.Confidence}.");
            }
        }
        
        public void ReturnMethod()
        {
            for (int i = 0; i <= targetFaceIds.Count - 1; i++)
            {
                if (targetFaceIds[i].Value == similarResults[0].FaceId)
                {
                    CurrentPersonURL = "https://" + DBImages[i].ImageFile;
                    CurrentPersonName = DBPeople[i].Name;
                    CurrentPersonDescription = DBPeople[i].Description;
                    CurrentPersonImageName = DBImages[i].ImageName;
                    CurrentPersonID = Convert.ToString(DBImages[i].PersonID);
                }
            }
        }
    }
}