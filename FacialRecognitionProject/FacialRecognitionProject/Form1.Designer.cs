namespace FacialRecognitionProject
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInputName = new System.Windows.Forms.TextBox();
            this.textBoxInputPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // textBoxInputName
            // 
            this.textBoxInputName.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputName.Location = new System.Drawing.Point(149, 30);
            this.textBoxInputName.Name = "textBoxInputName";
            this.textBoxInputName.Size = new System.Drawing.Size(282, 43);
            this.textBoxInputName.TabIndex = 2;
            // 
            // textBoxInputPassword
            // 
            this.textBoxInputPassword.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputPassword.Location = new System.Drawing.Point(149, 108);
            this.textBoxInputPassword.Name = "textBoxInputPassword";
            this.textBoxInputPassword.PasswordChar = '*';
            this.textBoxInputPassword.Size = new System.Drawing.Size(282, 43);
            this.textBoxInputPassword.TabIndex = 3;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(149, 215);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(282, 33);
            this.buttonLogIn.TabIndex = 4;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "Introducing S.O.F.I.A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Your facial identification assistant";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInputName);
            this.groupBox1.Controls.Add(this.textBoxInputPassword);
            this.groupBox1.Controls.Add(this.buttonLogIn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 254);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In to Proceed";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInputName;
        private System.Windows.Forms.TextBox textBoxInputPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

