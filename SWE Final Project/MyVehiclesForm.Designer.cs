
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
            this.components = new System.ComponentModel.Container();
            this.Butt_GoToProf = new System.Windows.Forms.Button();
            this.regVehicle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._SWE_ProjectDataSet = new SWE_Final_Project._SWE_ProjectDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.vehiclesTableAdapter = new SWE_Final_Project._SWE_ProjectDataSetTableAdapters.VehiclesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet)).BeginInit();
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
            // regVehicle
            // 
            this.regVehicle.Location = new System.Drawing.Point(12, 100);
            this.regVehicle.Name = "regVehicle";
            this.regVehicle.Size = new System.Drawing.Size(108, 61);
            this.regVehicle.TabIndex = 1;
            this.regVehicle.Text = "Register Vehicle";
            this.regVehicle.UseVisualStyleBackColor = true;
            this.regVehicle.Click += new System.EventHandler(this.regVehicle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(140, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 315);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this._SWE_ProjectDataSet;
            // 
            // _SWE_ProjectDataSet
            // 
            this._SWE_ProjectDataSet.DataSetName = "_SWE_ProjectDataSet";
            this._SWE_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Vehicles";
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // MyVehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.regVehicle);
            this.Controls.Add(this.Butt_GoToProf);
            this.Name = "MyVehiclesForm";
            this.Text = "My Vehicles";
            this.Load += new System.EventHandler(this.MyVehiclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butt_GoToProf;
        private System.Windows.Forms.Button regVehicle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private _SWE_ProjectDataSet _SWE_ProjectDataSet;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private _SWE_ProjectDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
    }
}