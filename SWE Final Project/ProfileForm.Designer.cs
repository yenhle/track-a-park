
namespace SWE_Final_Project
{
    partial class ProfileForm
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
            this.Butt_MyVehicles = new System.Windows.Forms.Button();
            this.Butt_ChkForParking = new System.Windows.Forms.Button();
            this.Lb_CurrentPoints = new System.Windows.Forms.Label();
            this.currentPoints = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Butt_MyVehicles
            // 
            this.Butt_MyVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Butt_MyVehicles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Butt_MyVehicles.FlatAppearance.BorderSize = 4;
            this.Butt_MyVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_MyVehicles.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_MyVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt_MyVehicles.Location = new System.Drawing.Point(163, 452);
            this.Butt_MyVehicles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Butt_MyVehicles.Name = "Butt_MyVehicles";
            this.Butt_MyVehicles.Size = new System.Drawing.Size(153, 70);
            this.Butt_MyVehicles.TabIndex = 0;
            this.Butt_MyVehicles.Text = "MY VEHICLES    >";
            this.Butt_MyVehicles.UseVisualStyleBackColor = false;
            this.Butt_MyVehicles.Click += new System.EventHandler(this.Butt_MyVehicles_Click);
            // 
            // Butt_ChkForParking
            // 
            this.Butt_ChkForParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Butt_ChkForParking.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Butt_ChkForParking.FlatAppearance.BorderSize = 4;
            this.Butt_ChkForParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_ChkForParking.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_ChkForParking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt_ChkForParking.Location = new System.Drawing.Point(431, 452);
            this.Butt_ChkForParking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Butt_ChkForParking.Name = "Butt_ChkForParking";
            this.Butt_ChkForParking.Size = new System.Drawing.Size(152, 70);
            this.Butt_ChkForParking.TabIndex = 2;
            this.Butt_ChkForParking.Text = "PARKING    >";
            this.Butt_ChkForParking.UseVisualStyleBackColor = false;
            this.Butt_ChkForParking.Click += new System.EventHandler(this.Butt_ChkForParking_Click);
            // 
            // Lb_CurrentPoints
            // 
            this.Lb_CurrentPoints.AutoSize = true;
            this.Lb_CurrentPoints.BackColor = System.Drawing.Color.White;
            this.Lb_CurrentPoints.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F);
            this.Lb_CurrentPoints.ForeColor = System.Drawing.Color.Silver;
            this.Lb_CurrentPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_CurrentPoints.Location = new System.Drawing.Point(306, 234);
            this.Lb_CurrentPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_CurrentPoints.Name = "Lb_CurrentPoints";
            this.Lb_CurrentPoints.Size = new System.Drawing.Size(135, 30);
            this.Lb_CurrentPoints.TabIndex = 4;
            this.Lb_CurrentPoints.Text = "Current Points:";
            // 
            // currentPoints
            // 
            this.currentPoints.AutoSize = true;
            this.currentPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.currentPoints.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPoints.Location = new System.Drawing.Point(362, 278);
            this.currentPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPoints.Name = "currentPoints";
            this.currentPoints.Size = new System.Drawing.Size(18, 24);
            this.currentPoints.TabIndex = 5;
            this.currentPoints.Text = "0";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.2F);
            this.button1.Location = new System.Drawing.Point(525, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 29F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(292, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(93, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(559, 489);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "My Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(134, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 237);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox3.Location = new System.Drawing.Point(400, 341);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(211, 237);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(159, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Check your vehicle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(159, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "information";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(426, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Check for available";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(326, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 16;
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(426, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "parking spot";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(750, 652);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Butt_ChkForParking);
            this.Controls.Add(this.Butt_MyVehicles);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currentPoints);
            this.Controls.Add(this.Lb_CurrentPoints);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProfileForm";
            this.Text = "User Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butt_MyVehicles;
        private System.Windows.Forms.Button Butt_ChkForParking;
        private System.Windows.Forms.Label Lb_CurrentPoints;
        private System.Windows.Forms.Label currentPoints;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}