﻿
namespace SWE_Final_Project
{
    partial class MyVehiclesForm
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
            this.Butt_GoToProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Butt_GoToProf
            // 
            this.Butt_GoToProf.Location = new System.Drawing.Point(12, 12);
            this.Butt_GoToProf.Name = "Butt_GoToProf";
            this.Butt_GoToProf.Size = new System.Drawing.Size(108, 61);
            this.Butt_GoToProf.TabIndex = 0;
            this.Butt_GoToProf.Text = "Go To Profile";
            this.Butt_GoToProf.UseVisualStyleBackColor = true;
            this.Butt_GoToProf.Click += new System.EventHandler(this.Butt_GoToProf_Click);
            // 
            // MyVehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Butt_GoToProf);
            this.Name = "MyVehiclesForm";
            this.Text = "My Vehicles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Butt_GoToProf;
    }
}