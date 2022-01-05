using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace ConvertirDeArchivos
{
    public partial class WordtoPDF : Form
    {
        FolderBrowserDialog CarpetaSalida;
       
        string RutaOrigen;
        string NombreOrigen;
        string RutaDestino;
        public WordtoPDF()
        {
            InitializeComponent();
        }

        private void btnOrigen_Click(object sender, EventArgs e)
        {
            OpenFileDialog cajaDialogo = new OpenFileDialog();
            cajaDialogo.Filter = "Archivo Word (.docx)|*.docx";


            DialogResult Resultado = cajaDialogo.ShowDialog();

            if (Resultado == DialogResult.OK)
            {
                RutaOrigen = cajaDialogo.FileName;
                NombreOrigen = Path.GetFileNameWithoutExtension(RutaOrigen);
                RutaDestino = Path.GetDirectoryName(RutaOrigen);

                txtDestino.Text = RutaDestino;
                txtOrigen.Text = RutaOrigen.ToString();

            }
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            CarpetaSalida = new FolderBrowserDialog();

            if (CarpetaSalida.ShowDialog() == DialogResult.OK)
            {
                txtDestino.Text = CarpetaSalida.SelectedPath;
                RutaDestino = txtDestino.Text;
    
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            //Crear un nuevo objeto de aplicación de Microsoft Word
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            //// C # no tiene argumentos opcionales, por lo que necesitaremos un valor ficticio
            object oMissing = System.Reflection.Missing.Value;
           
            FileInfo wordFile = new FileInfo(txtOrigen.Text); //Ruta de Origen del Documento
            word.Visible = false;
            word.ScreenUpdating = false;

            object FileName = (object)wordFile.FullName; //El nombre del documento.

            Document doc = word.Documents.Open(ref FileName, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            doc.Activate();

            object outputFileName = wordFile.FullName.Replace(".docx", ".pdf");
            object fileFormat = WdSaveFormat.wdFormatPDF; //El formato en el que se guarda el documento.

            // Guardar documento en formato PDF
            doc.SaveAs2(ref outputFileName, ref fileFormat,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);

            object savechanges = WdSaveOptions.wdSaveChanges;
            
            ((_Document)doc).Close(ref savechanges, ref oMissing, ref oMissing);
            doc = null;

            ((_Application)word).Quit(ref oMissing, ref oMissing, ref oMissing);
            word = null;

            MessageBox.Show("El archivo se ha convertido exitosamente a PDF");

            //Falta que se pueda guardar en el directorio Destino


        }
    }
}
     