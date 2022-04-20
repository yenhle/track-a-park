
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Butt_GoToProf = new System.Windows.Forms.Button();
            this.regVehicle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._SWE_ProjectDataSet = new SWE_Final_Project._SWE_ProjectDataSet();
            this.vehiclesTableAdapter = new SWE_Final_Project._SWE_ProjectDataSetTableAdapters.VehiclesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SWE_ProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Butt_GoToProf
            // 
            this.Butt_GoToProf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Butt_GoToProf.FlatAppearance.BorderSize = 5;
            this.Butt_GoToProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt_GoToProf.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_GoToProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt_GoToProf.Location = new System.Drawing.Point(29, 265);
            this.Butt_GoToProf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Butt_GoToProf.Name = "Butt_GoToProf";
            this.Butt_GoToProf.Size = new System.Drawing.Size(144, 75);
            this.Butt_GoToProf.TabIndex = 0;
            this.Butt_GoToProf.Text = "Go To Profile";
            this.Butt_GoToProf.UseVisualStyleBackColor = true;
            this.Butt_GoToProf.Click += new System.EventHandler(this.Butt_GoToProf_Click);
            // 
            // regVehicle
            // 
            this.regVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.regVehicle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.regVehicle.FlatAppearance.BorderSize = 5;
            this.regVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regVehicle.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 10F);
            this.regVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.regVehicle.Location = new System.Drawing.Point(29, 146);
            this.regVehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regVehicle.Name = "regVehicle";
            this.regVehicle.Size = new System.Drawing.Size(144, 75);
            this.regVehicle.TabIndex = 1;
            this.regVehicle.Text = "Register Vehicle";
            this.regVehicle.UseVisualStyleBackColor = false;
            this.regVehicle.Click += new System.EventHandler(this.regVehicle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(194, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(513, 447);
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
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(331, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current Vehicles";
            // 
            // MyVehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(750, 652);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.regVehicle);
            this.Controls.Add(this.Butt_GoToProf);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private _SWE_ProjectDataSet _SWE_ProjectDataSet;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private _SWE_ProjectDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}