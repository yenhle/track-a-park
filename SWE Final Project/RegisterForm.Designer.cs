
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
            this.LB_Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regUserBox = new System.Windows.Forms.TextBox();
            this.regPassBox = new System.Windows.Forms.TextBox();
            this.Butt_Register = new System.Windows.Forms.Button();
            this._SWE_ProjectDataSet = new SWE_Final_Project._SWE_ProjectDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new SWE_Final_Project._SWE_ProjectDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LB_Username.Location = new System.Drawing.Point(285, 45);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(177, 26);
            this.LB_Username.TabIndex = 2;
            this.LB_Username.Text = "Enter Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(285, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Password:";
            // 
            // regUserBox
            // 
            this.regUserBox.Location = new System.Drawing.Point(318, 102);
            this.regUserBox.Name = "regUserBox";
            this.regUserBox.Size = new System.Drawing.Size(100, 20);
            this.regUserBox.TabIndex = 4;
            // 
            // regPassBox
            // 
            this.regPassBox.Location = new System.Drawing.Point(318, 245);
            this.regPassBox.Name = "regPassBox";
            this.regPassBox.Size = new System.Drawing.Size(100, 20);
            this.regPassBox.TabIndex = 5;
            // 
            // Butt_Register
            // 
            this.Butt_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Butt_Register.Location = new System.Drawing.Point(301, 329);
            this.Butt_Register.Name = "Butt_Register";
            this.Butt_Register.Size = new System.Drawing.Size(144, 47);
            this.Butt_Register.TabIndex = 6;
            this.Butt_Register.Text = "Register";
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
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Butt_Register);
            this.Controls.Add(this.regPassBox);
            this.Controls.Add(this.regUserBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Username);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regUserBox;
        private System.Windows.Forms.TextBox regPassBox;
        private System.Windows.Forms.Button Butt_Register;
        private _SWE_ProjectDataSet _SWE_ProjectDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private _SWE_ProjectDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}