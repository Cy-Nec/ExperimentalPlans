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
        private int indexDataGrid = 1;
        private int[] dataCollection;
        private string[] factorNames = { "A", "B", "C", "D", "E" };
        public FormLat(int[] collectionData)
        {
            InitializeComponent();
            this.dataCollection = collectionData;

            for (int i = 0; i < dataCollection.Length; i++)
            {
                string item = $"{factorNames[i]}: {dataCollection[i]}";
                listBoxBasic.Items.Add(item);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormBase formBase = new FormBase();
            this.Close();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            indexDataGrid += 1;
            if (indexDataGrid > dataCollection.Length-1) indexDataGrid = 1;
            switch (indexDataGrid)
            {
                case 1:
                    dataGridView1.Visible = true;
                    dataGridView5.Visible = false;
                    label1.Text = $"План эксперимента №{indexDataGrid}";
                    break;
                case 2:
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = true;
                    label1.Text = $"План эксперимента №{indexDataGrid}";
                    break;
                case 3:
                    dataGridView3.Visible = true;
                    dataGridView2.Visible = false;
                    label1.Text = $"План эксперимента №{indexDataGrid}";
                    break;
                case 4:
                    dataGridView4.Visible = true;
                    dataGridView3.Visible = false;
                    label1.Text = $"План эксперимента №{indexDataGrid}";
                    break;
                case 5:
                    dataGridView5.Visible = true;
                    dataGridView4.Visible = false;
                    label1.Text = $"План эксперимента №{indexDataGrid}";
                    break;
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            indexDataGrid -= 1;
            if (indexDataGrid < 1) indexDataGrid = dataCollection.Length - 1;
            switch (indexDataGrid)
            {
                case 1:
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = false;
                    label1.Text = $"План эксперимента №{indexDataGrid}";
                    break;
                case 2:
                    dataGridView3.Visible = false;
                    dataGridView2.Visible = true;
                    label1.Text = $"План эксперимента №{indexDataGrid}";
                    break;
                case 3:
                    dataGridView3.Visible = true;
                    dataGridView4.Visible = false;
                    label1.Text = $"План эксперимента №{indexDataGrid}";
                    break;
                case 4:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = false;
                    label1.Text = $"План эксперимента №{indexDataGrid}";
                    break;
                case 5:
                    dataGridView5.Visible = true;
                    dataGridView1.Visible = false;
                    label1.Text = $"План эксперимента №{indexDataGrid}";
                    break;
            }
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            
        }

        // Метод для получения соответствующего DataGridView по индексу
        private DataGridView GetDataGridView(int index)
        {
            switch (index)
            {
                case 0: return dataGridView1;
                case 1: return dataGridView2;
                case 2: return dataGridView3;
                case 3: return dataGridView4;
                case 4: return dataGridView5;
                default: throw new ArgumentException("Недопустимый индекс DataGridView.");
            }
        }

        private void ClearDataGridViews()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            dataGridView5.Rows.Clear();
            dataGridView5.Columns.Clear();
        }
    }
}
