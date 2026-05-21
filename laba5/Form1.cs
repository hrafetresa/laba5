using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<LanguageData> languages = new List<LanguageData>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Введите название языка!");
                return;
            }

            string name = tbName.Text.Trim();
            int devs = (int)nudDevs.Value;
            int projects = (int)nudProjects.Value;

            LanguageData lang = new LanguageData(name, devs, projects);
            languages.Add(lang);

            listBoxPreview.Items.Add($"{name} (Разрабов: {devs}к, Проектов: {projects}к)");

            tbName.Clear();
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
                        foreach (var lang in languages)
                        {
                            writer.WriteLine($"{lang.Name};{lang.Devs};{lang.Projects}");
                        }
                    }
                    MessageBox.Show("Данные успешно сохранены!");
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
                    languages.Clear();
                    listBoxPreview.Items.Clear();

                    string[] lines = File.ReadAllLines(ofd.FileName);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length == 3)
                        {
                            string name = parts[0];
                            int devs = int.Parse(parts[1]);
                            int projects = int.Parse(parts[2]);

                            LanguageData lang = new LanguageData(name, devs, projects);
                            languages.Add(lang);
                            listBoxPreview.Items.Add($"{name} (Разрабов: {devs}к, Проектов: {projects}к)");
                        }
                    }
                    MessageBox.Show("Данные успешно загружены!");
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
            foreach (var lang in languages)
            {
                dgvResults.Rows.Add(lang.Name, lang.Devs, lang.Projects, lang.Index.ToString("F2"));
            }
        }

        private void UpdateCharts()
        {
            chartColumn.Series.Clear();
            chartColumn.ChartAreas.Clear();
            chartColumn.ChartAreas.Add(new ChartArea("MainArea"));

            Series colSeries = new Series("Projects")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };

            chartPie.Series.Clear();
            chartPie.ChartAreas.Clear();
            chartPie.ChartAreas.Add(new ChartArea("MainArea"));

            Series pieSeries = new Series("Developers")
            {
                ChartType = SeriesChartType.Pie,
                XValueType = ChartValueType.String
            };

            foreach (var lang in languages)
            {
                colSeries.Points.AddXY(lang.Name, lang.Projects);
                pieSeries.Points.AddXY(lang.Name, lang.Devs);
            }

            chartColumn.Series.Add(colSeries);
            chartPie.Series.Add(pieSeries);
        }
    }
}