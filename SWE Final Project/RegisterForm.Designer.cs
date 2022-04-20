
namespace SWE_Final_Project
{
    partial class RegisterForm
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
            this.regUserBox = new System.Windows.Forms.TextBox();
            this.regPassBox = new System.Windows.Forms.TextBox();
            this.Butt_Register = new System.Windows.Forms.Button();
            this._SWE_ProjectDataSet = new SWE_Final_Project._SWE_ProjectDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new SWE_Final_Project._SWE_ProjectDataSetTableAdapters.UsersTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_Password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // regUserBox
            // 
            this.regUserBox.Location = new System.Drawing.Point(267, 353);
            this.regUserBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regUserBox.Name = "regUserBox";
            this.regUserBox.Size = new System.Drawing.Size(193, 22);
            this.regUserBox.TabIndex = 4;
            // 
            // regPassBox
            // 
            this.regPassBox.Location = new System.Drawing.Point(267, 435);
            this.regPassBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regPassBox.Name = "regPassBox";
            this.regPassBox.Size = new System.Drawing.Size(193, 22);
            this.regPassBox.TabIndex = 5;
            this.regPassBox.TextChanged += new System.EventHandler(this.regPassBox_TextChanged);
            // 
            // Butt_Register
            // 
            this.Butt_Register.FlatAppearance.BorderSize = 0;
            this.Butt_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_Register.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 13.8F);
            this.Butt_Register.ForeColor = System.Drawing.Color.Green;
            this.Butt_Register.Location = new System.Drawing.Point(284, 496);
            this.Butt_Register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Butt_Register.Name = "Butt_Register";
            this.Butt_Register.Size = new System.Drawing.Size(157, 53);
            this.Butt_Register.TabIndex = 6;
            this.Butt_Register.Text = "REGISTER";
            this.Butt_Register.UseVisualStyleBackColor = true;
            this.Butt_Register.Click += new System.EventHandler(this.Butt_Register_Click);
            // 
            // _SWE_ProjectDataSet
            // 
            this._SWE_ProjectDataSet.DataSetName = "_SWE_ProjectDataSet";
            this._SWE_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this._SWE_ProjectDataSet;
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
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.BackColor = System.Drawing.Color.White;
            this.LB_Password.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Password.ForeColor = System.Drawing.Color.Gray;
            this.LB_Password.Location = new System.Drawing.Point(263, 405);
            this.LB_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(135, 24);
            this.LB_Password.TabIndex = 11;
            this.LB_Password.Text = "Enter password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(263, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter username:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(158, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(423, 379);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(264, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "REGISTER HERE!";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(750, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Butt_Register);
            this.Controls.Add(this.regPassBox);
            this.Controls.Add(this.regUserBox);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox regUserBox;
        private System.Windows.Forms.TextBox regPassBox;
        private System.Windows.Forms.Button Butt_Register;
        private _SWE_ProjectDataSet _SWE_ProjectDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private _SWE_ProjectDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}