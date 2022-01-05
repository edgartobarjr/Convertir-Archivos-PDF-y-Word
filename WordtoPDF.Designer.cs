
namespace ConvertirDeArchivos
{
    partial class WordtoPDF
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnOrigen = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carpeta Destino: ";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrigen.Location = new System.Drawing.Point(171, 35);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(386, 32);
            this.txtOrigen.TabIndex = 2;
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDestino.Location = new System.Drawing.Point(171, 109);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(386, 32);
            this.txtDestino.TabIndex = 3;
            // 
            // btnOrigen
            // 
            this.btnOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrigen.Image = global::ConvertirDeArchivos.Properties.Resources._272702_word_icon2;
            this.btnOrigen.Location = new System.Drawing.Point(571, 30);
            this.btnOrigen.Name = "btnOrigen";
            this.btnOrigen.Size = new System.Drawing.Size(149, 55);
            this.btnOrigen.TabIndex = 4;
            this.btnOrigen.Text = "Archivo Origen";
            this.btnOrigen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrigen.UseVisualStyleBackColor = true;
            this.btnOrigen.Click += new System.EventHandler(this.btnOrigen_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDestino.Image = global::ConvertirDeArchivos.Properties.Resources._416376_envelope_files_folder_interface_office_icon2;
            this.btnDestino.Location = new System.Drawing.Point(571, 104);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(149, 51);
            this.btnDestino.TabIndex = 5;
            this.btnDestino.Text = "Carpeta Destino";
            this.btnDestino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertir.Image = global::ConvertirDeArchivos.Properties.Resources._272699_pdf_icon__2_1;
            this.btnConvertir.Location = new System.Drawing.Point(289, 205);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(139, 54);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // WordtoPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 318);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnOrigen);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WordtoPDF";
            this.Text = "Convertir Word a PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnOrigen;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnConvertir;
    }
}