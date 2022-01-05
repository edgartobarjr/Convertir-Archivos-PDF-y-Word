using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConvertirDeArchivos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDFtoWord miForm = new PDFtoWord();
            miForm.Show();
        }

        private void btnWordtoPDF_Click(object sender, EventArgs e)
        {
            WordtoPDF miForm2 = new WordtoPDF();
            miForm2.Show();
        }
    }
}
