using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConvertirDeArchivos
{
    public partial class PDFtoWord : Form
    {
        FolderBrowserDialog CarpetaSalida;
        bool Convertir = false;
        string RutaOrigen;
        string NombreOrigen;
        string RutaDestino;
        public PDFtoWord()
        {
            InitializeComponent();
        }

        private void btnOrigen_Click(object sender, EventArgs e)
        {
            OpenFileDialog cajaDialogo = new OpenFileDialog();
            cajaDialogo.Filter = "Archivo PDF (.pdf)|*.pdf"; 
          

            DialogResult Resultado = cajaDialogo.ShowDialog();

            if (Resultado == DialogResult.OK)
            {
                RutaOrigen = cajaDialogo.FileName;
                NombreOrigen = Path.GetFileNameWithoutExtension(RutaOrigen);
                RutaDestino = Path.GetDirectoryName(RutaOrigen);

                txtDestino.Text = RutaDestino;
                txtOrigen.Text = RutaOrigen.ToString();

                Convertir = true;
            }
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            CarpetaSalida = new FolderBrowserDialog();

            if (CarpetaSalida.ShowDialog() == DialogResult.OK)
            {
                txtDestino.Text = CarpetaSalida.SelectedPath;
                RutaDestino = txtDestino.Text;
                Convertir = true;
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (Convertir)
            {
                SautinSoft.PdfFocus ArchivoPDF = new SautinSoft.PdfFocus();
                ArchivoPDF.OpenPdf(RutaOrigen);
                ArchivoPDF.ToWord(RutaDestino + "\\" + NombreOrigen + ".docx");
                System.Diagnostics.Process.Start(RutaDestino);
                MessageBox.Show("El archivo se ha convertido exitosamente a PDF");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
