
namespace ConvertirDeArchivos
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnPDFtoWord = new System.Windows.Forms.Button();
            this.btnWordtoPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convertir Archivos";
            // 
            // btnPDFtoWord
            // 
            this.btnPDFtoWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDFtoWord.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPDFtoWord.ForeColor = System.Drawing.Color.White;
            this.btnPDFtoWord.Location = new System.Drawing.Point(117, 202);
            this.btnPDFtoWord.Name = "btnPDFtoWord";
            this.btnPDFtoWord.Size = new System.Drawing.Size(227, 87);
            this.btnPDFtoWord.TabIndex = 1;
            this.btnPDFtoWord.Text = "PDF a Word";
            this.btnPDFtoWord.UseVisualStyleBackColor = false;
            this.btnPDFtoWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWordtoPDF
            // 
            this.btnWordtoPDF.BackColor = System.Drawing.Color.Teal;
            this.btnWordtoPDF.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWordtoPDF.ForeColor = System.Drawing.Color.White;
            this.btnWordtoPDF.Location = new System.Drawing.Point(501, 202);
            this.btnWordtoPDF.Name = "btnWordtoPDF";
            this.btnWordtoPDF.Size = new System.Drawing.Size(227, 87);
            this.btnWordtoPDF.TabIndex = 2;
            this.btnWordtoPDF.Text = "Word a PDF";
            this.btnWordtoPDF.UseVisualStyleBackColor = false;
            this.btnWordtoPDF.Click += new System.EventHandler(this.btnWordtoPDF_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWordtoPDF);
            this.Controls.Add(this.btnPDFtoWord);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPDFtoWord;
        private System.Windows.Forms.Button btnWordtoPDF;
    }
}