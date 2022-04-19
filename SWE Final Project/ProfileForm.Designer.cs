
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
            this.SuspendLayout();
            // 
            // Butt_MyVehicles
            // 
            this.Butt_MyVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Butt_MyVehicles.Location = new System.Drawing.Point(28, 57);
            this.Butt_MyVehicles.Name = "Butt_MyVehicles";
            this.Butt_MyVehicles.Size = new System.Drawing.Size(156, 86);
            this.Butt_MyVehicles.TabIndex = 0;
            this.Butt_MyVehicles.Text = "My Vehicles";
            this.Butt_MyVehicles.UseVisualStyleBackColor = true;
            this.Butt_MyVehicles.Click += new System.EventHandler(this.Butt_MyVehicles_Click);
            // 
            // Butt_ChkForParking
            // 
            this.Butt_ChkForParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Butt_ChkForParking.Location = new System.Drawing.Point(231, 57);
            this.Butt_ChkForParking.Name = "Butt_ChkForParking";
            this.Butt_ChkForParking.Size = new System.Drawing.Size(147, 86);
            this.Butt_ChkForParking.TabIndex = 2;
            this.Butt_ChkForParking.Text = "Check for Parking";
            this.Butt_ChkForParking.UseVisualStyleBackColor = true;
            this.Butt_ChkForParking.Click += new System.EventHandler(this.Butt_ChkForParking_Click);
            // 
            // Lb_CurrentPoints
            // 
            this.Lb_CurrentPoints.AutoSize = true;
            this.Lb_CurrentPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lb_CurrentPoints.Location = new System.Drawing.Point(24, 25);
            this.Lb_CurrentPoints.Name = "Lb_CurrentPoints";
            this.Lb_CurrentPoints.Size = new System.Drawing.Size(114, 20);
            this.Lb_CurrentPoints.TabIndex = 4;
            this.Lb_CurrentPoints.Text = "Current Points:";
            // 
            // currentPoints
            // 
            this.currentPoints.AutoSize = true;
            this.currentPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPoints.Location = new System.Drawing.Point(135, 28);
            this.currentPoints.Name = "currentPoints";
            this.currentPoints.Size = new System.Drawing.Size(16, 16);
            this.currentPoints.TabIndex = 5;
            this.currentPoints.Text = "0";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 209);
            this.Controls.Add(this.currentPoints);
            this.Controls.Add(this.Lb_CurrentPoints);
            this.Controls.Add(this.Butt_ChkForParking);
            this.Controls.Add(this.Butt_MyVehicles);
            this.Name = "ProfileForm";
            this.Text = "User Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butt_MyVehicles;
        private System.Windows.Forms.Button Butt_ChkForParking;
        private System.Windows.Forms.Label Lb_CurrentPoints;
        private System.Windows.Forms.Label currentPoints;
    }
}