
namespace ConvertirDeArchivos
{
    partial class PDFtoWord
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrigen = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carpeta Destino:";
            // 
            // btnOrigen
            // 
            this.btnOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrigen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrigen.Image = global::ConvertirDeArchivos.Properties.Resources._272699_pdf_icon__2_1;
            this.btnOrigen.Location = new System.Drawing.Point(576, 33);
            this.btnOrigen.Name = "btnOrigen";
            this.btnOrigen.Size = new System.Drawing.Size(151, 48);
            this.btnOrigen.TabIndex = 2;
            this.btnOrigen.Text = "Archivo Origen";
            this.btnOrigen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrigen.UseVisualStyleBackColor = true;
            this.btnOrigen.Click += new System.EventHandler(this.btnOrigen_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestino.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDestino.Image = global::ConvertirDeArchivos.Properties.Resources._416376_envelope_files_folder_interface_office_icon2;
            this.btnDestino.Location = new System.Drawing.Point(576, 103);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(151, 50);
            this.btnDestino.TabIndex = 3;
            this.btnDestino.Text = "Carpeta Destino";
            this.btnDestino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertir.Image = global::ConvertirDeArchivos.Properties.Resources._272702_word_icon2;
            this.btnConvertir.Location = new System.Drawing.Point(288, 200);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(144, 54);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrigen.Location = new System.Drawing.Point(172, 40);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(379, 32);
            this.txtOrigen.TabIndex = 5;
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDestino.Location = new System.Drawing.Point(171, 111);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(380, 32);
            this.txtDestino.TabIndex = 6;
            // 
            // PDFtoWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 329);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PDFtoWord";
            this.Text = "Convertir PDF a Word";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrigen;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
    }
}

