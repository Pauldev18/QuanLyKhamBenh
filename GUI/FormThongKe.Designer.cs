namespace GUI
{
    partial class FormThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.c_R_A = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c_R_A)).BeginInit();
            this.SuspendLayout();
            // 
            // c_R_A
            // 
            chartArea1.Name = "ChartArea1";
            this.c_R_A.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.c_R_A.Legends.Add(legend1);
            this.c_R_A.Location = new System.Drawing.Point(12, 96);
            this.c_R_A.Name = "c_R_A";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.c_R_A.Series.Add(series1);
            this.c_R_A.Size = new System.Drawing.Size(901, 430);
            this.c_R_A.TabIndex = 1;
            this.c_R_A.Text = "chart1";
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(86, 42);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(100, 20);
            this.txt_nam.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nam);
            this.Controls.Add(this.c_R_A);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_R_A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart c_R_A;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.Button button1;
    }
}