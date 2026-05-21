namespace laba5
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
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudProjects = new System.Windows.Forms.NumericUpDown();
            this.nudDevs = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInput = new System.Windows.Forms.TabPage();
            this.listBoxPreview = new System.Windows.Forms.ListBox();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDevs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpCharts = new System.Windows.Forms.TabPage();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDevs)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpInput.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.gbFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.tpCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnAdd);
            this.gbInput.Controls.Add(this.label3);
            this.gbInput.Controls.Add(this.nudProjects);
            this.gbInput.Controls.Add(this.nudDevs);
            this.gbInput.Controls.Add(this.label2);
            this.gbInput.Controls.Add(this.tbName);
            this.gbInput.Controls.Add(this.label1);
            this.gbInput.Location = new System.Drawing.Point(6, 6);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(280, 179);
            this.gbInput.TabIndex = 0;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Добавление языка";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 43);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить в список";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Всего проектов:";
            // 
            // nudProjects
            // 
            this.nudProjects.Location = new System.Drawing.Point(155, 81);
            this.nudProjects.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudProjects.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProjects.Name = "nudProjects";
            this.nudProjects.Size = new System.Drawing.Size(65, 20);
            this.nudProjects.TabIndex = 3;
            this.nudProjects.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDevs
            // 
            this.nudDevs.Location = new System.Drawing.Point(155, 51);
            this.nudDevs.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudDevs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDevs.Name = "nudDevs";
            this.nudDevs.Size = new System.Drawing.Size(65, 20);
            this.nudDevs.TabIndex = 3;
            this.nudDevs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Разработчиков (тыс. чел):";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(155, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название языка :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInput);
            this.tabControl1.Controls.Add(this.tpTable);
            this.tabControl1.Controls.Add(this.tpCharts);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 362);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpInput
            // 
            this.tpInput.Controls.Add(this.gbFiles);
            this.tpInput.Controls.Add(this.listBoxPreview);
            this.tpInput.Controls.Add(this.gbInput);
            this.tpInput.Location = new System.Drawing.Point(4, 22);
            this.tpInput.Name = "tpInput";
            this.tpInput.Padding = new System.Windows.Forms.Padding(3);
            this.tpInput.Size = new System.Drawing.Size(664, 336);
            this.tpInput.TabIndex = 0;
            this.tpInput.Text = "Ввод данных";
            this.tpInput.UseVisualStyleBackColor = true;
            // 
            // listBoxPreview
            // 
            this.listBoxPreview.FormattingEnabled = true;
            this.listBoxPreview.Location = new System.Drawing.Point(321, 26);
            this.listBoxPreview.Name = "listBoxPreview";
            this.listBoxPreview.Size = new System.Drawing.Size(294, 277);
            this.listBoxPreview.TabIndex = 0;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.dgvResults);
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(664, 336);
            this.tpTable.TabIndex = 1;
            this.tpTable.Text = "Таблица результатов";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.btnLoad);
            this.gbFiles.Controls.Add(this.btnSave);
            this.gbFiles.Location = new System.Drawing.Point(28, 209);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(258, 100);
            this.gbFiles.TabIndex = 0;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Управление  данными";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(130, 30);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 39);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Загрузить из файла";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить в файл";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDevs,
            this.colProjects,
            this.colIndex});
            this.dgvResults.Location = new System.Drawing.Point(6, 6);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(456, 167);
            this.dgvResults.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Язык программирования";
            this.colName.Name = "colName";
            // 
            // colDevs
            // 
            this.colDevs.HeaderText = "Разработчики (тыс. )";
            this.colDevs.Name = "colDevs";
            // 
            // colProjects
            // 
            this.colProjects.HeaderText = "Проекты (тыс. )";
            this.colProjects.Name = "colProjects";
            // 
            // colIndex
            // 
            this.colIndex.HeaderText = "Проектов на разработчика";
            this.colIndex.Name = "colIndex";
            // 
            // tpCharts
            // 
            this.tpCharts.Controls.Add(this.chartPie);
            this.tpCharts.Controls.Add(this.chartColumn);
            this.tpCharts.Location = new System.Drawing.Point(4, 22);
            this.tpCharts.Name = "tpCharts";
            this.tpCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tpCharts.Size = new System.Drawing.Size(664, 336);
            this.tpCharts.TabIndex = 2;
            this.tpCharts.Text = "Диаграммы";
            this.tpCharts.UseVisualStyleBackColor = true;
            // 
            // chartPie
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPie.Legends.Add(legend1);
            this.chartPie.Location = new System.Drawing.Point(337, 16);
            this.chartPie.Name = "chartPie";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPie.Series.Add(series1);
            this.chartPie.Size = new System.Drawing.Size(300, 300);
            this.chartPie.TabIndex = 0;
            this.chartPie.Text = "chart1";
            // 
            // chartColumn
            // 
            chartArea2.Name = "ChartArea1";
            this.chartColumn.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartColumn.Legends.Add(legend2);
            this.chartColumn.Location = new System.Drawing.Point(6, 16);
            this.chartColumn.Name = "chartColumn";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartColumn.Series.Add(series2);
            this.chartColumn.Size = new System.Drawing.Size(300, 300);
            this.chartColumn.TabIndex = 0;
            this.chartColumn.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 680);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDevs)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpInput.ResumeLayout(false);
            this.tpTable.ResumeLayout(false);
            this.gbFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.tpCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColumn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudProjects;
        private System.Windows.Forms.NumericUpDown nudDevs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpInput;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tpCharts;
        private System.Windows.Forms.ListBox listBoxPreview;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDevs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColumn;
    }
}

