using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kurs
{
    public partial class FormLat : Form
    {
        private int[] dataCollection;
        public FormLat(int[] collectionData)
        {
            InitializeComponent();
            this.dataCollection = collectionData;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormBase formBase = new FormBase();
            this.Close();
        }
    }
}
