namespace ChartApp
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CPU = new System.Windows.Forms.Button();
            this.Memory = new System.Windows.Forms.Button();
            this.Disk = new System.Windows.Forms.Button();
            this.pauseResume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sysChart
            // 
            chartArea2.Name = "ChartArea1";
            this.sysChart.ChartAreas.Add(chartArea2);
            this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.sysChart.Legends.Add(legend2);
            this.sysChart.Location = new System.Drawing.Point(0, 0);
            this.sysChart.Name = "sysChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.sysChart.Series.Add(series2);
            this.sysChart.Size = new System.Drawing.Size(684, 446);
            this.sysChart.TabIndex = 0;
            this.sysChart.Text = "sysChart";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CPU
            // 
            this.CPU.Location = new System.Drawing.Point(580, 310);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(80, 30);
            this.CPU.TabIndex = 1;
            this.CPU.Text = "CPU(ON)";
            this.CPU.UseVisualStyleBackColor = true;
            this.CPU.Click += new System.EventHandler(this.CPU_Click);
            // 
            // Memory
            // 
            this.Memory.Location = new System.Drawing.Point(580, 346);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(80, 30);
            this.Memory.TabIndex = 2;
            this.Memory.Text = "Memory(OFF)";
            this.Memory.UseVisualStyleBackColor = true;
            this.Memory.Click += new System.EventHandler(this.Memory_Click);
            // 
            // Disk
            // 
            this.Disk.Location = new System.Drawing.Point(580, 382);
            this.Disk.Name = "Disk";
            this.Disk.Size = new System.Drawing.Size(80, 30);
            this.Disk.TabIndex = 3;
            this.Disk.Text = "Disk(OFF)";
            this.Disk.UseVisualStyleBackColor = true;
            this.Disk.Click += new System.EventHandler(this.Disk_Click);
            // 
            // pauseResume
            // 
            this.pauseResume.Location = new System.Drawing.Point(580, 236);
            this.pauseResume.Name = "pauseResume";
            this.pauseResume.Size = new System.Drawing.Size(75, 23);
            this.pauseResume.TabIndex = 4;
            this.pauseResume.Text = "PAUSE ||";
            this.pauseResume.UseVisualStyleBackColor = true;
            this.pauseResume.Click += new System.EventHandler(this.pauseResume_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 446);
            this.Controls.Add(this.pauseResume);
            this.Controls.Add(this.Disk);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.sysChart);
            this.Name = "Main";
            this.Text = "System Metrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Disk;
        private System.Windows.Forms.Button Memory;
        private System.Windows.Forms.Button CPU;
        private System.Windows.Forms.Button pauseResume;
    }
}

