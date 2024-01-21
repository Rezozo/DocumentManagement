using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace documentManagement
{
    public partial class SelectFormats : MaterialForm
    {
        public SelectFormats()
        {
            InitializeComponent();
        }

        public string SelectedFormat { get; private set; }
        public string FileName { get; private set; } 

        private void pdfBtn_Click(object sender, EventArgs e)
        {
            if (fileNameTxt.Text != string.Empty)
            {
                SelectedFormat = "PDF";
                FileName = fileNameTxt.Text;
                DialogResult = DialogResult.OK;
                Close();
            } else
            {
                MessageBox.Show("Укажите название файла");
            }
        }

        private void txtBtn_Click(object sender, EventArgs e)
        {
            if (fileNameTxt.Text != string.Empty)
            {
                SelectedFormat = "TXT";
                FileName = fileNameTxt.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Укажите название файла");
            }
        }

        private void fileNameTxt_Enter(object sender, EventArgs e)
        {
            if (fileNameTxt.Text == "Введите название файла")
            {
                fileNameTxt.Clear();
                fileNameTxt.ForeColor = Color.Black;
            }
        }

        private void fileNameTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fileNameTxt.Text))
            {
                fileNameTxt.Text = "Введите название файла";
                fileNameTxt.ForeColor = Color.Gray;
            }
        }
    }
}
