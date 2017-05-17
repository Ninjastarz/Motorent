namespace OSTFinalProject
{
    partial class MainForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnAddVehicle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAddJourney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 266);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 116);
            this.listBox1.TabIndex = 0;
            // 
            // BtnAddVehicle
            // 
            this.BtnAddVehicle.Location = new System.Drawing.Point(25, 29);
            this.BtnAddVehicle.Name = "BtnAddVehicle";
            this.BtnAddVehicle.Size = new System.Drawing.Size(130, 33);
            this.BtnAddVehicle.TabIndex = 1;
            this.BtnAddVehicle.Text = "Add Vehicle";
            this.BtnAddVehicle.UseVisualStyleBackColor = true;
            this.BtnAddVehicle.Click += new System.EventHandler(this.BtnAddVehicle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnAddJourney
            // 
            this.BtnAddJourney.Location = new System.Drawing.Point(25, 68);
            this.BtnAddJourney.Name = "BtnAddJourney";
            this.BtnAddJourney.Size = new System.Drawing.Size(130, 35);
            this.BtnAddJourney.TabIndex = 3;
            this.BtnAddJourney.Text = "Register Journey";
            this.BtnAddJourney.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 404);
            this.Controls.Add(this.BtnAddJourney);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAddVehicle);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnAddVehicle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAddJourney;
    }
}

