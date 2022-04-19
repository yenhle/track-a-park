
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
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Username.ForeColor = System.Drawing.Color.Gray;
            this.LB_Username.Location = new System.Drawing.Point(207, 202);
            this.LB_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(126, 34);
            this.LB_Username.TabIndex = 0;
            this.LB_Username.Text = "Username";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(207, 246);
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
            this.passBox.Location = new System.Drawing.Point(207, 331);
            this.passBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(193, 22);
            this.passBox.TabIndex = 3;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Password.ForeColor = System.Drawing.Color.Gray;
            this.LB_Password.Location = new System.Drawing.Point(207, 287);
            this.LB_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(121, 34);
            this.LB_Password.TabIndex = 2;
            this.LB_Password.Text = "Password";
            // 
            // Butt_Login
            // 
            this.Butt_Login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Butt_Login.FlatAppearance.BorderSize = 4;
            this.Butt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Login.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Butt_Login.Location = new System.Drawing.Point(220, 386);
            this.Butt_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Butt_Login.Name = "Butt_Login";
            this.Butt_Login.Size = new System.Drawing.Size(169, 53);
            this.Butt_Login.TabIndex = 4;
            this.Butt_Login.Text = "Login";
            this.Butt_Login.UseVisualStyleBackColor = true;
            this.Butt_Login.Click += new System.EventHandler(this.Butt_Login_Click);
            // 
            // Butt_Register
            // 
            this.Butt_Register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Butt_Register.FlatAppearance.BorderSize = 4;
            this.Butt_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Register.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Butt_Register.Location = new System.Drawing.Point(220, 482);
            this.Butt_Register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Butt_Register.Name = "Butt_Register";
            this.Butt_Register.Size = new System.Drawing.Size(169, 53);
            this.Butt_Register.TabIndex = 5;
            this.Butt_Register.Text = "Register";
            this.Butt_Register.UseVisualStyleBackColor = true;
            this.Butt_Register.Click += new System.EventHandler(this.Butt_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10F);
            this.label1.Location = new System.Drawing.Point(222, 453);
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
            this.pictureBox1.Location = new System.Drawing.Point(244, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(637, 578);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Butt_Register);
            this.Controls.Add(this.Butt_Login);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.LB_Username);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "Login!";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

