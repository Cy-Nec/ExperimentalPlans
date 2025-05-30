using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kurs
{
    public partial class FormPlan : Form
    {
        private int[] levels = null;
        private FactorData[] factors = null;

        // Конструктор для полного, рандомного и плана с изменением по одному
        public FormPlan(FactorData[] dataCollection, string typePlan)
        {
            InitializeComponent();
            dataPlan.Columns.Add("ExperimentNumber", "№");
            dataPlan.Columns["ExperimentNumber"].Width = 40;

            string[] factorNames = { "A", "B", "C", "D", "E" };
            for (int i = 0; i < dataCollection.Length; i++)
            {
                string columnName = factorNames[i].ToString();
                dataPlan.Columns.Add(columnName, columnName);
                dataPlan.Columns[columnName].Width = 58;
            }

            if (typePlan == "Full")
            {
                List<List<string>> allCombinations = GenerateAllCombinations(dataCollection);
                foreach (var combination in allCombinations)
                    addDataPlan(combination);
                textBoxCount.Text = allCombinations.Count.ToString();
            }
            if (typePlan == "Rand")
            {
                labelCount.Location = new Point(labelCount.Location.X - 70, labelCount.Location.Y);
                labelCount.Text = "Введите количество экспериментов:";
                buttonGen.Visible = true;
                textBoxCount.ReadOnly = false;
                this.levels = dataCollection.Select(d => d.Count).ToArray();
                this.factors = dataCollection; // Сохраняем массив FactorData[]
            }
            if (typePlan == "One")
            {
                GenerateOnePlan(dataCollection);
                int experimentCount = 0;
                foreach (var factor in dataCollection)
                    experimentCount += factor.Count;
                textBoxCount.Text = experimentCount.ToString();
            }
        }

        // Конструктор для дробного плана
        public FormPlan(int factorsCount)
        {
            InitializeComponent();

            dataPlan.Columns.Add("ExperimentNumber", "№");
            dataPlan.Columns["ExperimentNumber"].Width = 40;

            string[] factorNames = { "A", "B", "C", "D", "E" };

            for (int i = 0; i < factorsCount; i++)
            {
                string columnName = factorNames[i].ToString();
                dataPlan.Columns.Add(columnName, columnName);
                dataPlan.Columns[columnName].Width = 58;
            }

            GenerateFractionalFactorialPlan(factorsCount);

            int experimentCount = (int)Math.Pow(2, factorsCount);
            textBoxCount.Text = experimentCount.ToString();
        }

        // Метод для генерации дробного факторного плана
        private void GenerateFractionalFactorialPlan(int factorsCount)
        {
            // Генерация всех комбинаций для двух уровней
            List<List<string>> allCombinations = GenerateBinaryCombinations(factorsCount);

            // Вывод комбинаций в DataGridView
            foreach (var combination in allCombinations)
                addDataPlan(combination);
        }

        // Метод для генерации всех бинарных комбинаций
        private List<List<string>> GenerateBinaryCombinations(int factorsCount)
        {
            List<List<string>> allCombinations = new List<List<string>>();
            int totalExperiments = (int)Math.Pow(2, factorsCount);

            for (int i = 0; i < totalExperiments; i++)
            {
                List<string> combination = new List<string>();

                for (int j = 0; j < factorsCount; j++)
                {
                    int value = (i >> j) & 1;
                    combination.Add(value.ToString());
                }
                combination.Reverse();
                allCombinations.Add(combination);
            }
            return allCombinations;
        }

        private List<List<string>> GenerateAllCombinations(FactorData[] factors)
        {
            List<List<string>> allCombinations = new List<List<string>>();
            List<string> currentCombination = new List<string>();
            GenerateCombinationsRecursive(factors, 0, currentCombination, allCombinations);
            return allCombinations;
        }

        private void GenerateCombinationsRecursive(FactorData[] factors, int currentFactorIndex, List<string> currentCombination, List<List<string>> allCombinations)
        {
            if (currentFactorIndex == factors.Length)
            {
                allCombinations.Add(new List<string>(currentCombination));
                return;
            }

            foreach (var value in factors[currentFactorIndex].Values)
            {
                currentCombination.Add(value.ToString());
                GenerateCombinationsRecursive(factors, currentFactorIndex + 1, currentCombination, allCombinations);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }

        private void addDataPlan(List<string> combination)
        {
            int rowIndex = dataPlan.Rows.Add();
            dataPlan.Rows[rowIndex].Cells["ExperimentNumber"].Value = (rowIndex + 1).ToString();
            for (int i = 0; i < combination.Count; i++)
                dataPlan.Rows[rowIndex].Cells[i + 1].Value = combination[i];
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormBase formBase = new FormBase();
            this.Close();
        }

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.KeyChar = (char)0;
        }

        private void generateRandomizedPlan(FactorData[] factors, int experimentCount)
        {
            List<List<string>> allCombinations = GenerateAllCombinations(factors);

            // Проверка, что количество запрашиваемых экспериментов не превышает общее число комбинаций
            if (experimentCount > allCombinations.Count)
            {
                MessageBox.Show($"Количество экспериментов превышает общее число возможных комбинаций ({allCombinations.Count}).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Случайный выбор комбинаций
            Random random = new Random();
            List<List<string>> selectedCombinations = allCombinations.OrderBy(x => random.Next()).Take(experimentCount).ToList();
            foreach (var combination in selectedCombinations)
                addDataPlan(combination);
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Введите количество экспериментов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int experimentCount;
            if (!int.TryParse(textBoxCount.Text, out experimentCount) || experimentCount < 1 || experimentCount > 500)
            {
                MessageBox.Show("Количество экспериментов должно быть числом от 1 до 500.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataPlan.Rows.Clear();
            generateRandomizedPlan(this.factors, experimentCount);
        }

        private void GenerateOnePlan(FactorData[] factors)
        {
            // Фиксированные значения для всех факторов
            List<string> fixedValues = factors.Select(factor => factor.Values[0].ToString()).ToList();

            for (int factorIndex = 0; factorIndex < factors.Length; factorIndex++)
            {
                foreach (var level in factors[factorIndex].Values)
                {
                    List<string> combination = new List<string>(fixedValues);
                    combination[factorIndex] = level.ToString();
                    addDataPlan(combination);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Проверка на наличие данных в таблице
            if (dataPlan.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Открытие диалога сохранения файла
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить данные в CSV";
                saveFileDialog.DefaultExt = "csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog.FileName))
                        {
                            // Запись заголовков столбцов
                            var headers = dataPlan.Columns.Cast<DataGridViewColumn>()
                                                         .Select(column => column.HeaderText)
                                                         .ToArray();
                            writer.WriteLine(string.Join(";", headers));

                            // Запись данных строк
                            foreach (DataGridViewRow row in dataPlan.Rows)
                            {
                                var rowData = row.Cells.Cast<DataGridViewCell>()
                                                       .Select(cell => cell.Value?.ToString() ?? "")
                                                       .ToArray();
                                writer.WriteLine(string.Join(";", rowData));
                            }
                        }

                        MessageBox.Show("Данные успешно сохранены в CSV.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}