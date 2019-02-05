namespace TestBatproject
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Showbutton = new System.Windows.Forms.Button();
            this.ListViewRecievedNodes = new System.Windows.Forms.ListView();
            this.Lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClusterHeadListView = new System.Windows.Forms.ListView();
            this.BatPosXTextBox = new System.Windows.Forms.TextBox();
            this.BatPosYTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NormalCHlistView = new System.Windows.Forms.ListView();
            this.CDTlistView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(43, 12);
            this.chart1.Name = "chart1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Legend = "Legend1";
            series8.Name = "BatNode";
            series8.YValuesPerPoint = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Legend = "Legend1";
            series9.Name = "GroundNode";
            series9.YValuesPerPoint = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series10.Legend = "Legend1";
            series10.Name = "SinkNode";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.Legend = "Legend1";
            series11.Name = "RecievedNode";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series12.Legend = "Legend1";
            series12.Name = "ClusterHead";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series13.Legend = "Legend1";
            series13.MarkerColor = System.Drawing.Color.Red;
            series13.Name = "ClMofCH1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series14.Legend = "Legend1";
            series14.MarkerBorderColor = System.Drawing.Color.Black;
            series14.Name = "CMofCH2";
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(588, 325);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(713, 87);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(75, 23);
            this.Showbutton.TabIndex = 1;
            this.Showbutton.Text = "Show";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // ListViewRecievedNodes
            // 
            this.ListViewRecievedNodes.Location = new System.Drawing.Point(479, 150);
            this.ListViewRecievedNodes.Name = "ListViewRecievedNodes";
            this.ListViewRecievedNodes.Size = new System.Drawing.Size(112, 29);
            this.ListViewRecievedNodes.TabIndex = 2;
            this.ListViewRecievedNodes.UseCompatibleStateImageBehavior = false;
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(476, 134);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(129, 13);
            this.Lable1.TabIndex = 3;
            this.Lable1.Text = "# Nodes Recieved Signal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "# Cluster Heads";
            // 
            // ClusterHeadListView
            // 
            this.ClusterHeadListView.Location = new System.Drawing.Point(479, 198);
            this.ClusterHeadListView.Name = "ClusterHeadListView";
            this.ClusterHeadListView.Size = new System.Drawing.Size(110, 32);
            this.ClusterHeadListView.TabIndex = 5;
            this.ClusterHeadListView.UseCompatibleStateImageBehavior = false;
            // 
            // BatPosXTextBox
            // 
            this.BatPosXTextBox.Location = new System.Drawing.Point(728, 22);
            this.BatPosXTextBox.Name = "BatPosXTextBox";
            this.BatPosXTextBox.Size = new System.Drawing.Size(52, 20);
            this.BatPosXTextBox.TabIndex = 6;
            // 
            // BatPosYTextBox
            // 
            this.BatPosYTextBox.Location = new System.Drawing.Point(728, 51);
            this.BatPosYTextBox.Name = "BatPosYTextBox";
            this.BatPosYTextBox.Size = new System.Drawing.Size(52, 20);
            this.BatPosYTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Bat X Pos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Bat Y Pos";
            // 
            // NormalCHlistView
            // 
            this.NormalCHlistView.Location = new System.Drawing.Point(479, 249);
            this.NormalCHlistView.Name = "NormalCHlistView";
            this.NormalCHlistView.Size = new System.Drawing.Size(96, 35);
            this.NormalCHlistView.TabIndex = 10;
            this.NormalCHlistView.UseCompatibleStateImageBehavior = false;
            // 
            // CDTlistView
            // 
            this.CDTlistView.Location = new System.Drawing.Point(479, 304);
            this.CDTlistView.Name = "CDTlistView";
            this.CDTlistView.Size = new System.Drawing.Size(96, 33);
            this.CDTlistView.TabIndex = 11;
            this.CDTlistView.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Normal Clustering Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "CDT Clustering Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CDTlistView);
            this.Controls.Add(this.NormalCHlistView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BatPosYTextBox);
            this.Controls.Add(this.BatPosXTextBox);
            this.Controls.Add(this.ClusterHeadListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lable1);
            this.Controls.Add(this.ListViewRecievedNodes);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.ListView ListViewRecievedNodes;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ClusterHeadListView;
        private System.Windows.Forms.TextBox BatPosXTextBox;
        private System.Windows.Forms.TextBox BatPosYTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView NormalCHlistView;
        private System.Windows.Forms.ListView CDTlistView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

