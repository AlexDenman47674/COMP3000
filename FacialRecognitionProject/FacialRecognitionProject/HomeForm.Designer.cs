namespace FacialRecognitionProject
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.buttonCamera = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDatabase = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FacialRecognitionProject.Properties.Resources.SOFIALogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(417, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "How can I help you today?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(753, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logged In As:";
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentUser.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUser.Location = new System.Drawing.Point(888, 9);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(66, 37);
            this.labelCurrentUser.TabIndex = 3;
            this.labelCurrentUser.Text = "USER";
            // 
            // buttonCamera
            // 
            this.buttonCamera.BackColor = System.Drawing.Color.White;
            this.buttonCamera.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCamera.Location = new System.Drawing.Point(6, 36);
            this.buttonCamera.Name = "buttonCamera";
            this.buttonCamera.Size = new System.Drawing.Size(297, 33);
            this.buttonCamera.TabIndex = 5;
            this.buttonCamera.Text = "Access Camera";
            this.buttonCamera.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAbout);
            this.groupBox1.Controls.Add(this.buttonSettings);
            this.groupBox1.Controls.Add(this.buttonDatabase);
            this.groupBox1.Controls.Add(this.buttonCamera);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 487);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // buttonDatabase
            // 
            this.buttonDatabase.BackColor = System.Drawing.Color.White;
            this.buttonDatabase.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDatabase.Location = new System.Drawing.Point(6, 108);
            this.buttonDatabase.Name = "buttonDatabase";
            this.buttonDatabase.Size = new System.Drawing.Size(297, 33);
            this.buttonDatabase.TabIndex = 6;
            this.buttonDatabase.Text = "Access Database";
            this.buttonDatabase.UseVisualStyleBackColor = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.White;
            this.buttonSettings.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(6, 185);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(297, 33);
            this.buttonSettings.TabIndex = 7;
            this.buttonSettings.Text = "User Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.White;
            this.buttonAbout.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(6, 265);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(297, 33);
            this.buttonAbout.TabIndex = 7;
            this.buttonAbout.Text = "About Us";
            this.buttonAbout.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(369, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 487);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Home";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FacialRecognitionProject.Properties.Resources.MainBackground;
            this.ClientSize = new System.Drawing.Size(1007, 806);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCurrentUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HomeForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Button buttonCamera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDatabase;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}