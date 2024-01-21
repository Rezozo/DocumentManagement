using documentManagement.files;
using documentManagement.models;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace documentManagement
{
    public partial class GenerateFile : MaterialForm
    {
        private FileCreater fileCreater;
        private Deal _deal;

        public GenerateFile()
        {
            InitializeComponent();
            fileCreater = new FileCreater();
        }

        public models.Deal deal { get { return _deal; } set { _deal = value; } }

        private void paymentPdfBtn_Click(object sender, EventArgs e)
        {
            if (fileNameTxt.Text != string.Empty)
            {
                fileCreater.GeneratePdfPaymentList(fileNameTxt.Text, _deal);
                Hide();
            } else
            {
                MessageBox.Show("Укажите название файла");
            }
        }

        private void txtBtn_Click(object sender, EventArgs e)
        {
            if (fileNameTxt.Text != string.Empty)
            {
                fileCreater.GenerateTXT(fileNameTxt.Text, _deal);
                Hide();
            } else
            {
                MessageBox.Show("Укажите название файла");
            }
        }

        private void pdfBtn_Click(object sender, EventArgs e)
        {
            if (fileNameTxt.Text != string.Empty)
            {
                fileCreater.GeneratePDF(fileNameTxt.Text, _deal);
                Hide();
            }
            else
            {
                MessageBox.Show("Укажите название файла");
            }
        }
    }
}
