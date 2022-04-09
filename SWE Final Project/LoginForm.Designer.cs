
namespace SWE_Final_Project
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
            this.LB_Username = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LB_Password = new System.Windows.Forms.Label();
            this.Butt_Login = new System.Windows.Forms.Button();
            this.Butt_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LB_Username.Location = new System.Drawing.Point(171, 78);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(113, 26);
            this.LB_Username.TabIndex = 0;
            this.LB_Username.Text = "Username";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(176, 117);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(100, 20);
            this.TB_UserName.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LB_Password.Location = new System.Drawing.Point(171, 164);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(108, 26);
            this.LB_Password.TabIndex = 2;
            this.LB_Password.Text = "Password";
            // 
            // Butt_Login
            // 
            this.Butt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Butt_Login.Location = new System.Drawing.Point(176, 256);
            this.Butt_Login.Name = "Butt_Login";
            this.Butt_Login.Size = new System.Drawing.Size(108, 47);
            this.Butt_Login.TabIndex = 4;
            this.Butt_Login.Text = "Login";
            this.Butt_Login.UseVisualStyleBackColor = true;
            this.Butt_Login.Click += new System.EventHandler(this.Butt_Login_Click);
            // 
            // Butt_Register
            // 
            this.Butt_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Butt_Register.Location = new System.Drawing.Point(176, 341);
            this.Butt_Register.Name = "Butt_Register";
            this.Butt_Register.Size = new System.Drawing.Size(108, 47);
            this.Butt_Register.TabIndex = 5;
            this.Butt_Register.Text = "Register";
            this.Butt_Register.UseVisualStyleBackColor = true;
            this.Butt_Register.Click += new System.EventHandler(this.Butt_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "No acc? Register!";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Butt_Register);
            this.Controls.Add(this.Butt_Login);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.LB_Username);
            this.Name = "LoginForm";
            this.Text = "Login!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.Button Butt_Login;
        private System.Windows.Forms.Button Butt_Register;
        private System.Windows.Forms.Label label1;
    }
}

