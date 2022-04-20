
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
            this.components = new System.ComponentModel.Container();
            this.LB_Username = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._SWE_ProjectDataSet = new SWE_Final_Project._SWE_ProjectDataSet();
            this.passBox = new System.Windows.Forms.TextBox();
            this.LB_Password = new System.Windows.Forms.Label();
            this.Butt_Login = new System.Windows.Forms.Button();
            this.Butt_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usersTableAdapter = new SWE_Final_Project._SWE_ProjectDataSetTableAdapters.UsersTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._SWE_ProjectDataSet1 = new SWE_Final_Project._SWE_ProjectDataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.BackColor = System.Drawing.Color.White;
            this.LB_Username.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Username.ForeColor = System.Drawing.Color.Gray;
            this.LB_Username.Location = new System.Drawing.Point(263, 242);
            this.LB_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(88, 24);
            this.LB_Username.TabIndex = 0;
            this.LB_Username.Text = "username";
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.White;
            this.userBox.Location = new System.Drawing.Point(265, 279);
            this.userBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(193, 22);
            this.userBox.TabIndex = 1;
            this.userBox.TextChanged += new System.EventHandler(this.userBox_TextChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this._SWE_ProjectDataSet;
            // 
            // _SWE_ProjectDataSet
            // 
            this._SWE_ProjectDataSet.DataSetName = "_SWE_ProjectDataSet";
            this._SWE_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(265, 361);
            this.passBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(193, 22);
            this.passBox.TabIndex = 3;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.BackColor = System.Drawing.Color.White;
            this.LB_Password.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Password.ForeColor = System.Drawing.Color.Gray;
            this.LB_Password.Location = new System.Drawing.Point(263, 324);
            this.LB_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(84, 24);
            this.LB_Password.TabIndex = 2;
            this.LB_Password.Text = "password";
            // 
            // Butt_Login
            // 
            this.Butt_Login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Butt_Login.FlatAppearance.BorderSize = 0;
            this.Butt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Login.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Login.ForeColor = System.Drawing.Color.Green;
            this.Butt_Login.Location = new System.Drawing.Point(275, 409);
            this.Butt_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Butt_Login.Name = "Butt_Login";
            this.Butt_Login.Size = new System.Drawing.Size(169, 53);
            this.Butt_Login.TabIndex = 4;
            this.Butt_Login.Text = "LOGIN";
            this.Butt_Login.UseVisualStyleBackColor = true;
            this.Butt_Login.Click += new System.EventHandler(this.Butt_Login_Click);
            // 
            // Butt_Register
            // 
            this.Butt_Register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Butt_Register.FlatAppearance.BorderSize = 0;
            this.Butt_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Register.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Register.ForeColor = System.Drawing.Color.Green;
            this.Butt_Register.Location = new System.Drawing.Point(276, 504);
            this.Butt_Register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Butt_Register.Name = "Butt_Register";
            this.Butt_Register.Size = new System.Drawing.Size(169, 53);
            this.Butt_Register.TabIndex = 5;
            this.Butt_Register.Text = "REGISTER";
            this.Butt_Register.UseVisualStyleBackColor = true;
            this.Butt_Register.Click += new System.EventHandler(this.Butt_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10F);
            this.label1.Location = new System.Drawing.Point(280, 477);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "No acccount? Register!";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SWE_Final_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(284, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // _SWE_ProjectDataSet1
            // 
            this._SWE_ProjectDataSet1.DataSetName = "_SWE_ProjectDataSet";
            this._SWE_ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(158, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(423, 379);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(750, 652);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Butt_Register);
            this.Controls.Add(this.Butt_Login);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.LB_Username);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "Login!";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.Button Butt_Login;
        private System.Windows.Forms.Button Butt_Register;
        private System.Windows.Forms.Label label1;
        private _SWE_ProjectDataSet _SWE_ProjectDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private _SWE_ProjectDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _SWE_ProjectDataSet _SWE_ProjectDataSet1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

