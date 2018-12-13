namespace WerewolfClient
{
    partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TbLogin = new System.Windows.Forms.TextBox();
			this.TbPassword = new System.Windows.Forms.TextBox();
			this.BtnSignIn = new System.Windows.Forms.Button();
			this.BtnSignUp = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TBServer = new System.Windows.Forms.TextBox();
			this.TwoPL = new System.Windows.Forms.Button();
			this.FourPL = new System.Windows.Forms.Button();
			this.SixteenPL = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(256, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(221, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// TbLogin
			// 
			this.TbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TbLogin.Location = new System.Drawing.Point(319, 105);
			this.TbLogin.Name = "TbLogin";
			this.TbLogin.Size = new System.Drawing.Size(273, 29);
			this.TbLogin.TabIndex = 2;
			// 
			// TbPassword
			// 
			this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TbPassword.Location = new System.Drawing.Point(319, 140);
			this.TbPassword.Name = "TbPassword";
			this.TbPassword.PasswordChar = '*';
			this.TbPassword.Size = new System.Drawing.Size(273, 29);
			this.TbPassword.TabIndex = 3;
			// 
			// BtnSignIn
			// 
			this.BtnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSignIn.Location = new System.Drawing.Point(459, 188);
			this.BtnSignIn.Name = "BtnSignIn";
			this.BtnSignIn.Size = new System.Drawing.Size(94, 45);
			this.BtnSignIn.TabIndex = 4;
			this.BtnSignIn.Text = "Sign In";
			this.BtnSignIn.UseVisualStyleBackColor = true;
			this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
			// 
			// BtnSignUp
			// 
			this.BtnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSignUp.Location = new System.Drawing.Point(349, 188);
			this.BtnSignUp.Name = "BtnSignUp";
			this.BtnSignUp.Size = new System.Drawing.Size(94, 45);
			this.BtnSignUp.TabIndex = 5;
			this.BtnSignUp.Text = "Sign Up";
			this.BtnSignUp.UseVisualStyleBackColor = true;
			this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(42, 41);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 93);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(199, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "API Address";
			// 
			// TBServer
			// 
			this.TBServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBServer.Location = new System.Drawing.Point(319, 69);
			this.TBServer.Name = "TBServer";
			this.TBServer.Size = new System.Drawing.Size(273, 29);
			this.TBServer.TabIndex = 8;
			this.TBServer.Text = "http://localhost:2343/werewolf/";
			// 
			// TwoPL
			// 
			this.TwoPL.Location = new System.Drawing.Point(319, 33);
			this.TwoPL.Margin = new System.Windows.Forms.Padding(2);
			this.TwoPL.Name = "TwoPL";
			this.TwoPL.Size = new System.Drawing.Size(74, 31);
			this.TwoPL.TabIndex = 9;
			this.TwoPL.Text = "2 Player";
			this.TwoPL.UseVisualStyleBackColor = true;
			this.TwoPL.Click += new System.EventHandler(this.TwoPL_Click);
			// 
			// FourPL
			// 
			this.FourPL.Location = new System.Drawing.Point(397, 33);
			this.FourPL.Margin = new System.Windows.Forms.Padding(2);
			this.FourPL.Name = "FourPL";
			this.FourPL.Size = new System.Drawing.Size(76, 31);
			this.FourPL.TabIndex = 10;
			this.FourPL.Text = "4 Player";
			this.FourPL.UseVisualStyleBackColor = true;
			this.FourPL.Click += new System.EventHandler(this.FourPL_Click);
			// 
			// SixteenPL
			// 
			this.SixteenPL.Location = new System.Drawing.Point(477, 33);
			this.SixteenPL.Margin = new System.Windows.Forms.Padding(2);
			this.SixteenPL.Name = "SixteenPL";
			this.SixteenPL.Size = new System.Drawing.Size(76, 31);
			this.SixteenPL.TabIndex = 11;
			this.SixteenPL.Text = "16 Player";
			this.SixteenPL.UseVisualStyleBackColor = true;
			this.SixteenPL.Click += new System.EventHandler(this.SixteenPL_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(195, 37);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 22);
			this.label4.TabIndex = 12;
			this.label4.Text = "Select Server";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(54, 146);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "How to Play";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 264);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.SixteenPL);
			this.Controls.Add(this.FourPL);
			this.Controls.Add(this.TwoPL);
			this.Controls.Add(this.TBServer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.BtnSignUp);
			this.Controls.Add(this.BtnSignIn);
			this.Controls.Add(this.TbPassword);
			this.Controls.Add(this.TbLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBServer;
        private System.Windows.Forms.Button TwoPL;
        private System.Windows.Forms.Button FourPL;
        private System.Windows.Forms.Button SixteenPL;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
	}
}