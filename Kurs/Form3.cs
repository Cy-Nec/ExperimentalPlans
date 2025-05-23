using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kurs
{
    public partial class FormLat : Form
    {
        private int totalExperiments = 0;
        private int indexDataGrid = 1;
        private int[] dataCollection;
        private string[] factorNames = { "A", "B", "C", "D", "E" };
        private int totalGrids = 0;

        private FactorData[] factors = null;

        public FormLat(FactorData[] collectionData)
        {
            InitializeComponent();
            this.factors = collectionData; // Сохраняем массив FactorData[]
            this.dataCollection = collectionData.Select(d => d.Count).ToArray(); // Извлекаем количество уровней

            for (int i = 0; i < collectionData.Length; i++)
            {
                string item = $"{factorNames[i]}: {dataCollection[i]}";
                listBoxBasic.Items.Add(item);
            }
        }

        // Функции отображения полей для показа данных
        private void HideAllGrids()
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
        }
        private void ShowGrid(int index)
        {
            HideAllGrids();
            GetDataGridView(index).Visible = true;
            label1.Text = $"План эксперимента №{index + 1}";
        }

        // Блок взаимодействия с интерфейсом
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormBase formBase = new FormBase();
            this.Close();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (totalGrids == 0) return;

            indexDataGrid = (indexDataGrid + 1) % totalGrids;
            ShowGrid(indexDataGrid);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (totalGrids == 0) return;

            indexDataGrid = (indexDataGrid - 1 + totalGrids) % totalGrids;
            ShowGrid(indexDataGrid);
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            if (listBoxBasic.SelectedIndex == -1 || listBoxExtra.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите первичный и вторичный фактор.");
                return;
            }

            ClearDataGridViews();

            int basicIndex = listBoxBasic.SelectedIndex;
            string primaryFactor = factorNames[basicIndex];
            int levelCount = dataCollection[basicIndex];

            // Получение значения уровней для основного фактора
            List<double> primaryValues = factors[basicIndex].Values;

            string rowFactor = listBoxExtra.SelectedItem.ToString().Split(':')[0];

            List<string> columnFactors = new List<string>();
            foreach (var item in listBoxExtra.Items)
            {
                string factor = item.ToString().Split(':')[0];
                if (factor != rowFactor)
                    columnFactors.Add(factor);
            }

            totalExperiments = 0; // Сброс счетчика экспериментов

            int gridIndex = 0;
            foreach (string colFactor in columnFactors)
            {
                if (gridIndex >= 3) break;

                // Генерация латинского квадрата
                string[,] square = GenerateLatinSquare(levelCount, primaryValues);

                DataGridView grid = GetDataGridView(gridIndex);

                grid.Columns.Clear();
                grid.Rows.Clear();
                grid.RowHeadersVisible = true;

                for (int i = 0; i < levelCount; i++)
                    grid.Columns.Add($"col{i}", $"{colFactor}{i + 1}");

                for (int i = 0; i < levelCount; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(grid);
                    for (int j = 0; j < levelCount; j++)
                        row.Cells[j].Value = square[i, j];
                    row.HeaderCell.Value = $"{rowFactor}{i + 1}";
                    grid.Rows.Add(row);
                }

                grid.Visible = true;
                gridIndex++;

                // Подсчет экспериментов для текущего квадрата
                totalExperiments += levelCount * levelCount;
            }

            indexDataGrid = 0;
            ShowGrid(indexDataGrid);
            label1.Text = "План эксперимента №1";
            totalGrids = columnFactors.Count > 3 ? 3 : columnFactors.Count;

            // Вывод общего количества экспериментов
            textBoxCount.Text = totalExperiments.ToString();
        }

        private string[,] GenerateLatinSquare(int n, List<double> values)
        {
            string[,] square = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    square[i, j] = values[(i + j) % n].ToString();
                }
            }
            return square;
        }

        private DataGridView GetDataGridView(int index)
        {
            switch (index)
            {
                case 0: return dataGridView1;
                case 1: return dataGridView2;
                case 2: return dataGridView3;
                default: throw new ArgumentException("Недопустимый индекс DataGridView");
            }
        }

        // Функция выбора базового фактора
        private void listBoxBasic_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxExtra.Items.Clear();

            int basicFactorIndex = listBoxBasic.SelectedIndex;
            int basicFactorLevels = dataCollection[basicFactorIndex];

            for (int i = 0; i < dataCollection.Length; i++)
                if (i != basicFactorIndex)
                {
                    string item = $"{factorNames[i]}: {basicFactorLevels}";
                    listBoxExtra.Items.Add(item);
                }
        }

        private void ClearDataGridViews()
        {
            foreach (var grid in new[] { dataGridView1, dataGridView2, dataGridView3 })
            {
                grid.Rows.Clear();
                grid.Columns.Clear();
                grid.Visible = false;
            }
        }
    }
}
