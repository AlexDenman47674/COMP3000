﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace FacialRecognitionProject
{
    class AzureFace
    {
        const string SUBSCRIPTION_KEY = "SUBSCRIPTION KEY GOES HERE";
        const string ENDPOINT = "END POINT GOES HERE";
        const string IMAGE_BASE_URL = "https://csdx.blob.core.windows.net/resources/Face/Images/";


        static void AzureMain(string[] args)
        {
            const string RECOGNITION_MODEL4 = RecognitionModel.Recognition04;

            // Authenticate.
            IFaceClient client = Authenticate(ENDPOINT, SUBSCRIPTION_KEY);

            // Detect - get features from faces.
            DetectFaceExtract(client, IMAGE_BASE_URL, RECOGNITION_MODEL4).Wait();
            // Find Similar - find a similar face from a list of faces.
            FindSimilar(client, IMAGE_BASE_URL, RECOGNITION_MODEL4).Wait();
            // Verify - compare two images if the same person or not.
            Verify(client, IMAGE_BASE_URL, RECOGNITION_MODEL4).Wait();

            // Identify - recognize a face(s) in a person group (a person group is created in this example).
            IdentifyInPersonGroup(client, IMAGE_BASE_URL, RECOGNITION_MODEL4).Wait();
            // LargePersonGroup - create, then get data.
            LargePersonGroup(client, IMAGE_BASE_URL, RECOGNITION_MODEL4).Wait();
            // Group faces - automatically group similar faces.
            Group(client, IMAGE_BASE_URL, RECOGNITION_MODEL4).Wait();
            // FaceList - create a face list, then get data
        }

        /*
        *	AUTHENTICATE
        *	Uses subscription key and region to create a client.
        */
        public static IFaceClient Authenticate(string endpoint, string key)
        {
            return new FaceClient(new ApiKeyServiceClientCredentials(key)) { Endpoint = endpoint };
        }
    }
}
