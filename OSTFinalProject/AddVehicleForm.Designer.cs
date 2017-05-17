namespace OSTFinalProject
{
    partial class AddVehicleForm
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
            this.vehicleData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleData)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleData
            // 
            this.vehicleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleData.Location = new System.Drawing.Point(12, 92);
            this.vehicleData.Name = "vehicleData";
            this.vehicleData.RowTemplate.Height = 24;
            this.vehicleData.Size = new System.Drawing.Size(533, 301);
            this.vehicleData.TabIndex = 0;
            this.vehicleData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleData_CellContentClick);
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 405);
            this.Controls.Add(this.vehicleData);
            this.Name = "AddVehicleForm";
            this.Text = "AddVehicleForm";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vehicleData;
    }
}