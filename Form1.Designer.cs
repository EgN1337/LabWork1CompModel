namespace LabWork1CompModel
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
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.MatOjidanie = new System.Windows.Forms.Button();
      this.Dispersiya = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.AddItems = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // MatOjidanie
      // 
      this.MatOjidanie.Location = new System.Drawing.Point(257, 12);
      this.MatOjidanie.Name = "MatOjidanie";
      this.MatOjidanie.Size = new System.Drawing.Size(259, 36);
      this.MatOjidanie.TabIndex = 0;
      this.MatOjidanie.Text = "Рассчитать математическое ожидание";
      this.MatOjidanie.UseVisualStyleBackColor = true;
      this.MatOjidanie.Click += new System.EventHandler(this.MatOjidanie_Click);
      // 
      // Dispersiya
      // 
      this.Dispersiya.Location = new System.Drawing.Point(257, 54);
      this.Dispersiya.Name = "Dispersiya";
      this.Dispersiya.Size = new System.Drawing.Size(259, 30);
      this.Dispersiya.TabIndex = 1;
      this.Dispersiya.Text = "Рассчитать дисперсию";
      this.Dispersiya.UseVisualStyleBackColor = true;
      this.Dispersiya.Click += new System.EventHandler(this.Dispersiya_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(257, 90);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(259, 35);
      this.button1.TabIndex = 2;
      this.button1.Text = "Рассчитать второй момент";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(257, 132);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(259, 37);
      this.button2.TabIndex = 3;
      this.button2.Text = "Рассчитать третий момент";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // AddItems
      // 
      this.AddItems.Location = new System.Drawing.Point(11, 389);
      this.AddItems.Margin = new System.Windows.Forms.Padding(2);
      this.AddItems.Name = "AddItems";
      this.AddItems.Size = new System.Drawing.Size(209, 35);
      this.AddItems.TabIndex = 4;
      this.AddItems.Text = "Сформировать элементы генератором";
      this.AddItems.UseVisualStyleBackColor = true;
      this.AddItems.Click += new System.EventHandler(this.button3_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(11, 90);
      this.listBox1.Margin = new System.Windows.Forms.Padding(2);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(148, 290);
      this.listBox1.TabIndex = 5;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(543, 12);
      this.textBox1.Margin = new System.Windows.Forms.Padding(2);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(160, 20);
      this.textBox1.TabIndex = 6;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(543, 54);
      this.textBox2.Margin = new System.Windows.Forms.Padding(2);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(160, 20);
      this.textBox2.TabIndex = 7;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(543, 90);
      this.textBox3.Margin = new System.Windows.Forms.Padding(2);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(160, 20);
      this.textBox3.TabIndex = 8;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(543, 132);
      this.textBox4.Margin = new System.Windows.Forms.Padding(2);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(160, 20);
      this.textBox4.TabIndex = 9;
      // 
      // chart2
      // 
      this.chart2.BorderSkin.BackColor = System.Drawing.Color.OrangeRed;
      this.chart2.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
      this.chart2.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
      chartArea1.Name = "ChartArea1";
      this.chart2.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart2.Legends.Add(legend1);
      this.chart2.Location = new System.Drawing.Point(303, 389);
      this.chart2.Margin = new System.Windows.Forms.Padding(2);
      this.chart2.Name = "chart2";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Статистическая функция распределения";
      this.chart2.Series.Add(series1);
      this.chart2.Size = new System.Drawing.Size(597, 210);
      this.chart2.TabIndex = 11;
      this.chart2.Text = "chart2";
      // 
      // chart1
      // 
      chartArea2.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea2);
      legend2.Name = "Legend1";
      this.chart1.Legends.Add(legend2);
      this.chart1.Location = new System.Drawing.Point(303, 175);
      this.chart1.Name = "chart1";
      series2.ChartArea = "ChartArea1";
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chart1.Series.Add(series2);
      this.chart1.Size = new System.Drawing.Size(597, 209);
      this.chart1.TabIndex = 12;
      this.chart1.Text = "chart1";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(172, 13);
      this.label1.TabIndex = 13;
      this.label1.Text = "Введите количество интервалов";
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(12, 53);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(148, 20);
      this.textBox5.TabIndex = 14;
      this.textBox5.TextChanged += new System.EventHandler(this.IntervalCount);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.ClientSize = new System.Drawing.Size(1419, 677);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.chart2);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.AddItems);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.Dispersiya);
      this.Controls.Add(this.MatOjidanie);
      this.Name = "Form1";
      this.Text = "Лабораторная №2";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button MatOjidanie;
        private System.Windows.Forms.Button Dispersiya;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddItems;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
    }
}

