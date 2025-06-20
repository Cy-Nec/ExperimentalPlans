﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kurs
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        // Функция отключения элементов интерфейса
        private void visibleOff()
        {
            label2.Visible = false;
            buttonPlan.Visible = false;
            textBox1.Clear();

            labelA.Visible = false;
            textBoxA.Visible = false;

            labelB.Visible = false;
            textBoxB.Visible = false;

            labelC.Visible = false;
            textBoxC.Visible = false;

            labelD.Visible = false;
            textBoxD.Visible = false;

            labelE.Visible = false;
            textBoxE.Visible = false;
        }

        // Функция сбора данных из полей ввода
        private FactorData[] collectData(int factorCount)
        {
            var data = new FactorData[factorCount];
            for (int i = 0; i < factorCount; i++)
            {
                string input = "";
                switch (i)
                {
                    case 0: input = textBoxA.Text; break;
                    case 1: input = textBoxB.Text; break;
                    case 2: input = textBoxC.Text; break;
                    case 3: input = textBoxD.Text; break;
                    case 4: input = textBoxE.Text; break;
                }

                var parts = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(part => part.Trim())
                                 .ToArray();

                if (parts.Length < 2 || !int.TryParse(parts[0], out int levelCount))
                {
                    throw new FormatException("Некорректный формат ввода.");
                }

                var values = parts.Skip(1).Select(double.Parse).ToList();
                if (values.Count != levelCount)
                {
                    string errFactor = null;
                    switch (i)
                    {
                        case 0: errFactor = "A"; break;
                        case 1: errFactor = "B"; break;
                        case 2: errFactor = "C"; break;
                        case 3: errFactor = "D"; break;
                        case 4: errFactor = "E"; break;
                    }
                    throw new FormatException($"Количество значений не соответствует количеству уровней (Фактор {errFactor}).");
                }

                data[i] = new FactorData(levelCount, values);
            }
            return data;
        }

        // Функция проверки заполненности полей
        private bool areaIsFill()
        {
            List<TextBox> visibleTextBox = new List<TextBox> {textBoxA, textBoxB, textBoxC, textBoxD, textBoxE};

            foreach (var textBox in visibleTextBox)
                if (textBox.Visible && string.IsNullOrEmpty(textBox.Text)) 
                    return false;
            return true;
        }

        // Ограничение ввода данных в поле количество уровней
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonLat.Checked)
            {
                if (!(e.KeyChar >= '3' && e.KeyChar <= '5' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
            }
            else
                if (!(e.KeyChar >= '1' && e.KeyChar <= '5' || e.KeyChar == (char)8))
                        e.KeyChar = (char)0;

            if (textBox1.Text.Length >= 1 && e.KeyChar != (char)8)
            {
                e.KeyChar = (char)0;
            }
        }

        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonFractional.Checked && textBoxA.Text == "")
                if (!(e.KeyChar == '2' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
            if (radioButtonFractional.Checked && textBoxA.Text.Length == 1)
                if (!(e.KeyChar == ';' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;

            if ((radioButtonFull.Checked || radioButtonRand.Checked
                || radioButtonOne.Checked || radioButtonLat.Checked) && (textBoxA.Text == ""))
                if (!(e.KeyChar >= '1' && e.KeyChar <= '5' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
            if ((radioButtonFull.Checked || radioButtonRand.Checked
                || radioButtonOne.Checked || radioButtonLat.Checked) && (textBoxA.Text.Length == 1))
                if (!(e.KeyChar == ';' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
        }
        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonFractional.Checked && textBoxB.Text == "")
                if (!(e.KeyChar == '2' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
            if (radioButtonFractional.Checked && textBoxB.Text.Length == 1)
                if (!(e.KeyChar == ';' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;

            if ((radioButtonFull.Checked || radioButtonRand.Checked
                || radioButtonOne.Checked || radioButtonLat.Checked) && (textBoxB.Text == ""))
                if (!(e.KeyChar >= '1' && e.KeyChar <= '5' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
            if ((radioButtonFull.Checked || radioButtonRand.Checked
                || radioButtonOne.Checked || radioButtonLat.Checked) && (textBoxB.Text.Length == 1))
                if (!(e.KeyChar == ';' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
        }
        private void textBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonFractional.Checked && textBoxC.Text == "")
                if (!(e.KeyChar == '2' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
            if (radioButtonFractional.Checked && textBoxC.Text.Length == 1)
                if (!(e.KeyChar == ';' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;

            if ((radioButtonFull.Checked || radioButtonRand.Checked
                || radioButtonOne.Checked || radioButtonLat.Checked) && (textBoxC.Text == ""))
                if (!(e.KeyChar >= '1' && e.KeyChar <= '5' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
            if ((radioButtonFull.Checked || radioButtonRand.Checked
                || radioButtonOne.Checked || radioButtonLat.Checked) && (textBoxC.Text.Length == 1))
                if (!(e.KeyChar == ';' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
        }
        private void textBoxD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonFractional.Checked && textBoxD.Text == "")
                if (!(e.KeyChar == '2' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
            if (radioButtonFractional.Checked && textBoxD.Text.Length == 1)
                if (!(e.KeyChar == ';' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;

            if ((radioButtonFull.Checked || radioButtonRand.Checked
                || radioButtonOne.Checked || radioButtonLat.Checked) && (textBoxD.Text == ""))
                if (!(e.KeyChar >= '1' && e.KeyChar <= '5' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
            if ((radioButtonFull.Checked || radioButtonRand.Checked
                || radioButtonOne.Checked || radioButtonLat.Checked) && (textBoxD.Text.Length == 1))
                if (!(e.KeyChar == ';' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
        }
        private void textBoxE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonFractional.Checked && textBoxE.Text == "")
                if (!(e.KeyChar == '2' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
            if (radioButtonFractional.Checked && textBoxE.Text.Length == 1)
                if (!(e.KeyChar == ';' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;

            if ((radioButtonFull.Checked || radioButtonRand.Checked
                || radioButtonOne.Checked || radioButtonLat.Checked) && (textBoxE.Text == ""))
                if (!(e.KeyChar >= '1' && e.KeyChar <= '5' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
            if ((radioButtonFull.Checked || radioButtonRand.Checked
                || radioButtonOne.Checked || radioButtonLat.Checked) && (textBoxE.Text.Length == 1))
                if (!(e.KeyChar == ';' || e.KeyChar == (char)8))
                    e.KeyChar = (char)0;
        }

        // Кнопка отображения полей ввода
        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButtonFull.Checked || radioButtonRand.Checked 
               || radioButtonOne.Checked || radioButtonLat.Checked 
               || radioButtonFractional.Checked)
               && int.TryParse(textBox1.Text, out int factorCount))
            {
                label2.Visible = true;
                buttonPlan.Visible = true;
                for (int i = 0; i < factorCount; i++)
                {
                    switch (i)
                    {
                        case 0:
                            labelA.Visible = true;
                            textBoxA.Visible = true;
                            textBoxA.Clear();
                            break;
                        case 1:
                            labelB.Visible = true;
                            textBoxB.Visible = true;
                            textBoxB.Clear();
                            break;
                        case 2:
                            labelC.Visible = true;
                            textBoxC.Visible = true;
                            textBoxC.Clear();
                            break;
                        case 3:
                            labelD.Visible = true;
                            textBoxD.Visible = true;
                            textBoxD.Clear();
                            break;
                        case 4:
                            labelE.Visible = true;
                            textBoxE.Visible = true;
                            textBoxE.Clear();
                            break;
                    }
                }
            }
        }

        // Блок отслеживания изменения состояния всех radioButton
        private void radioButtonFull_CheckedChanged(object sender, EventArgs e)
        {
            buttonFill.Visible = radioButtonFull.Checked;
            visibleOff();
            label1.Text = "Количество факторов (1-5):";
        }

        private void radioButtonRand_CheckedChanged(object sender, EventArgs e)
        {
            buttonFill.Visible = radioButtonRand.Checked;
            visibleOff();
            label1.Text = "Количество факторов (1-5):";
        }

        private void radioButtonOne_CheckedChanged(object sender, EventArgs e)
        {
            buttonFill.Visible = radioButtonOne.Checked;
            visibleOff();
            label1.Text = "Количество факторов (1-5):";
        }

        private void radioButtonFractional_CheckedChanged(object sender, EventArgs e)
        {
            buttonFill.Visible = radioButtonFractional.Checked;
            visibleOff();
            label1.Text = "Количество факторов (1-5):";
        }

        private void radioButtonLat_CheckedChanged(object sender, EventArgs e)
        {
            buttonFill.Visible = radioButtonLat.Checked;
            visibleOff();
            label1.Text = "Количество факторов (3-5):";
        }

        // Кнопка создания плана
        private void buttonPlan_Click(object sender, EventArgs e)
        {
            if (!areaIsFill())
            {
                labelError.Visible = true;
                return;
            }
            labelError.Visible = false;

            try
            {
                var collectedData = collectData(int.Parse(textBox1.Text));
                if (radioButtonLat.Checked)
                {
                    FormLat formLat = new FormLat(collectedData);
                    this.Hide();
                    formLat.ShowDialog();
                    this.Show();
                }
                else
                {
                    string formPlanTitle = "Полный факторный эксперимент";
                    string type = "Full";
                    if (radioButtonRand.Checked)
                    {
                        formPlanTitle = "Рандомизированный план";
                        type = "Rand";
                    }
                    else if (radioButtonOne.Checked)
                    {
                        formPlanTitle = "Эксперимент с изменением фактора по одному";
                        type = "One";
                    }
                    else if (radioButtonFractional.Checked)
                    {
                        formPlanTitle = "Дробный факторный эксперимент";
                        type = "Fract";
                    }

                    FormPlan formPlan = new FormPlan(collectedData, type);
                    formPlan.Text = formPlanTitle;
                    this.Hide();
                    formPlan.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка ввода данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReferenceFill_Click(object sender, EventArgs e)
        {
            Reference reference = new Reference();
            reference.Show();
        }
    }

    public class FactorData
    {
        public int Count { get; set; }
        public List<double> Values { get; set; }

        public FactorData(int count, List<double> values)
        {
            Count = count;
            Values = values;
        }
    }
}
