namespace Lab_9_simmod
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_p1 = new System.Windows.Forms.TextBox();
            this.tb_p2 = new System.Windows.Forms.TextBox();
            this.tb_p3 = new System.Windows.Forms.TextBox();
            this.tb_p4 = new System.Windows.Forms.TextBox();
            this.tb_p5 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.b_start = new System.Windows.Forms.Button();
            this.l_exp = new System.Windows.Forms.Label();
            this.tb_exp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // tb_p1
            // 
            this.tb_p1.Location = new System.Drawing.Point(84, 74);
            this.tb_p1.Name = "tb_p1";
            this.tb_p1.Size = new System.Drawing.Size(66, 22);
            this.tb_p1.TabIndex = 5;
            // 
            // tb_p2
            // 
            this.tb_p2.Location = new System.Drawing.Point(84, 115);
            this.tb_p2.Name = "tb_p2";
            this.tb_p2.Size = new System.Drawing.Size(66, 22);
            this.tb_p2.TabIndex = 6;
            // 
            // tb_p3
            // 
            this.tb_p3.Location = new System.Drawing.Point(84, 153);
            this.tb_p3.Name = "tb_p3";
            this.tb_p3.Size = new System.Drawing.Size(66, 22);
            this.tb_p3.TabIndex = 7;
            // 
            // tb_p4
            // 
            this.tb_p4.Location = new System.Drawing.Point(84, 191);
            this.tb_p4.Name = "tb_p4";
            this.tb_p4.Size = new System.Drawing.Size(66, 22);
            this.tb_p4.TabIndex = 8;
            // 
            // tb_p5
            // 
            this.tb_p5.Location = new System.Drawing.Point(84, 229);
            this.tb_p5.Name = "tb_p5";
            this.tb_p5.Size = new System.Drawing.Size(66, 22);
            this.tb_p5.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(269, 69);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(519, 336);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(12, 363);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(149, 42);
            this.b_start.TabIndex = 11;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // l_exp
            // 
            this.l_exp.AutoSize = true;
            this.l_exp.Location = new System.Drawing.Point(15, 290);
            this.l_exp.Name = "l_exp";
            this.l_exp.Size = new System.Drawing.Size(89, 17);
            this.l_exp.TabIndex = 12;
            this.l_exp.Text = "Experiments:";
            // 
            // tb_exp
            // 
            this.tb_exp.Location = new System.Drawing.Point(110, 287);
            this.tb_exp.Name = "tb_exp";
            this.tb_exp.Size = new System.Drawing.Size(57, 22);
            this.tb_exp.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Введите вероятности (после нуля запятая):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_exp);
            this.Controls.Add(this.l_exp);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tb_p5);
            this.Controls.Add(this.tb_p4);
            this.Controls.Add(this.tb_p3);
            this.Controls.Add(this.tb_p2);
            this.Controls.Add(this.tb_p1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_p1;
        private System.Windows.Forms.TextBox tb_p2;
        private System.Windows.Forms.TextBox tb_p3;
        private System.Windows.Forms.TextBox tb_p4;
        private System.Windows.Forms.TextBox tb_p5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Label l_exp;
        private System.Windows.Forms.TextBox tb_exp;
        private System.Windows.Forms.Label label6;
    }
}

