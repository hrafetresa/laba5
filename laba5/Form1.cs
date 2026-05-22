using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace laba5
{
    public partial class Form1 : Form
    {
        private List<DailyReport> reports = new List<DailyReport>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string day = dtpDay.Text.Trim();
            double rev = (double)nudDevs.Value;     
            double exp = (double)nudProjects.Value;

            DailyReport dayData = new DailyReport(day, rev, exp);
            reports.Add(dayData);

            DailyReport.CalculateWeeklyMetrics(reports);

            listBoxPreview.Items.Add($"{day} (Выручка: {rev}к, Расходы: {exp}к, Прибыль: {dayData.Profit}к)");

            nudDevs.Value = 1;
            nudProjects.Value = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        writer.WriteLine($"Финансовый отчет ресторана. Количество дней: {reports.Count}");
                        foreach (var r in reports)
                        {
                            writer.WriteLine($"{r.Day};{r.Revenue};{r.Expenses}");
                        }
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    reports.Clear();
                    listBoxPreview.Items.Clear();

                    string[] lines = File.ReadAllLines(ofd.FileName);

                    int startIndex = (lines.Length > 0 && !lines[0].Contains(";")) ? 1 : 0;

                    for (int i = startIndex; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(';');
                        if (parts.Length == 3)
                        {
                            string day = parts[0];
                            double rev = double.Parse(parts[1]);
                            double exp = double.Parse(parts[2]);

                            DailyReport r = new DailyReport(day, rev, exp);
                            reports.Add(r);
                            listBoxPreview.Items.Add($"{day} (Выручка: {rev}к, Расходы: {exp}к, Прибыль: {r.Profit}к)");
                        }
                    }

                    DailyReport.CalculateWeeklyMetrics(reports);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                UpdateTable();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                UpdateCharts();
            }
        }

        private void UpdateTable()
        {
            dgvResults.Rows.Clear();
            foreach (var r in reports)
            {
                dgvResults.Rows.Add(r.Day, r.Revenue, r.Expenses, r.Profit, r.Deviation.ToString("F2"));
            }
        }

        private void UpdateCharts()
        {
            chartColumn.Series.Clear();
            chartColumn.ChartAreas.Clear();
            chartColumn.ChartAreas.Add(new ChartArea("MainArea"));

            Series colSeries = new Series("Чистая прибыль (тыс.руб)")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };

            chartPie.Annotations.Clear();
            Border3DAnnotation annotation = new Border3DAnnotation();
            annotation.Text = "Чистая прибыль(тыс. руб)";
            annotation.Font = new Font("Arial", 9, FontStyle.Regular);
            annotation.ForeColor = Color.Black;
            annotation.BackColor = Color.White;
            annotation.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            annotation.BorderSkin.BackColor = Color.Gray;
            annotation.X = 1;
            annotation.Y = 1;

            chartPie.Annotations.Add(annotation);


            chartPie.Series.Clear();
            chartPie.ChartAreas.Clear();
            chartPie.ChartAreas.Add(new ChartArea("MainArea"));
            chartPie.ChartAreas[0].Area3DStyle.Enable3D = true; 

            Series pieSeries = new Series("Расходы")
            {
                ChartType = SeriesChartType.Pie,
                XValueType = ChartValueType.String,
            };

            pieSeries["PieLabelStyle"] = "Disabled";

            foreach (var r in reports)
            {
                colSeries.Points.AddXY(r.Day, r.Profit);
                pieSeries.Points.AddXY(r.Day, r.Profit);
            }

            chartColumn.Series.Add(colSeries);
            chartPie.Series.Add(pieSeries);


            
        }
    }
}