
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
            this.Butt_MyPoints = new System.Windows.Forms.Button();
            this.Butt_ChkForParking = new System.Windows.Forms.Button();
            this.Butt_ReserveParking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Butt_MyVehicles
            // 
            this.Butt_MyVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Butt_MyVehicles.Location = new System.Drawing.Point(77, 57);
            this.Butt_MyVehicles.Name = "Butt_MyVehicles";
            this.Butt_MyVehicles.Size = new System.Drawing.Size(126, 68);
            this.Butt_MyVehicles.TabIndex = 0;
            this.Butt_MyVehicles.Text = "My Vehicles";
            this.Butt_MyVehicles.UseVisualStyleBackColor = true;
            // 
            // Butt_MyPoints
            // 
            this.Butt_MyPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Butt_MyPoints.Location = new System.Drawing.Point(77, 163);
            this.Butt_MyPoints.Name = "Butt_MyPoints";
            this.Butt_MyPoints.Size = new System.Drawing.Size(126, 68);
            this.Butt_MyPoints.TabIndex = 1;
            this.Butt_MyPoints.Text = "My Points";
            this.Butt_MyPoints.UseVisualStyleBackColor = true;
            // 
            // Butt_ChkForParking
            // 
            this.Butt_ChkForParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Butt_ChkForParking.Location = new System.Drawing.Point(261, 57);
            this.Butt_ChkForParking.Name = "Butt_ChkForParking";
            this.Butt_ChkForParking.Size = new System.Drawing.Size(126, 68);
            this.Butt_ChkForParking.TabIndex = 2;
            this.Butt_ChkForParking.Text = "Check for Parking";
            this.Butt_ChkForParking.UseVisualStyleBackColor = true;
            // 
            // Butt_ReserveParking
            // 
            this.Butt_ReserveParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Butt_ReserveParking.Location = new System.Drawing.Point(261, 163);
            this.Butt_ReserveParking.Name = "Butt_ReserveParking";
            this.Butt_ReserveParking.Size = new System.Drawing.Size(126, 68);
            this.Butt_ReserveParking.TabIndex = 3;
            this.Butt_ReserveParking.Text = "Reserve Parking";
            this.Butt_ReserveParking.UseVisualStyleBackColor = true;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 297);
            this.Controls.Add(this.Butt_ReserveParking);
            this.Controls.Add(this.Butt_ChkForParking);
            this.Controls.Add(this.Butt_MyPoints);
            this.Controls.Add(this.Butt_MyVehicles);
            this.Name = "ProfileForm";
            this.Text = "User Profile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Butt_MyVehicles;
        private System.Windows.Forms.Button Butt_MyPoints;
        private System.Windows.Forms.Button Butt_ChkForParking;
        private System.Windows.Forms.Button Butt_ReserveParking;
    }
}