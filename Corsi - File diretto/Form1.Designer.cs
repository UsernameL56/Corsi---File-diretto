namespace Corsi___File_diretto
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.salva = new System.Windows.Forms.Button();
            this.stampa = new System.Windows.Forms.Button();
            this.cancella = new System.Windows.Forms.Button();
            this.svuota = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // salva
            // 
            this.salva.Location = new System.Drawing.Point(51, 233);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(75, 23);
            this.salva.TabIndex = 0;
            this.salva.Text = "Salva";
            this.salva.UseVisualStyleBackColor = true;
            this.salva.Click += new System.EventHandler(this.salva_Click);
            // 
            // stampa
            // 
            this.stampa.Location = new System.Drawing.Point(160, 233);
            this.stampa.Name = "stampa";
            this.stampa.Size = new System.Drawing.Size(75, 23);
            this.stampa.TabIndex = 1;
            this.stampa.Text = "Stampa";
            this.stampa.UseVisualStyleBackColor = true;
            this.stampa.Click += new System.EventHandler(this.stampa_Click);
            // 
            // cancella
            // 
            this.cancella.Location = new System.Drawing.Point(51, 284);
            this.cancella.Name = "cancella";
            this.cancella.Size = new System.Drawing.Size(75, 23);
            this.cancella.TabIndex = 2;
            this.cancella.Text = "Cancella";
            this.cancella.UseVisualStyleBackColor = true;
            this.cancella.Click += new System.EventHandler(this.cancella_Click);
            // 
            // svuota
            // 
            this.svuota.Location = new System.Drawing.Point(51, 415);
            this.svuota.Name = "svuota";
            this.svuota.Size = new System.Drawing.Size(102, 23);
            this.svuota.TabIndex = 3;
            this.svuota.Text = "Svuota File";
            this.svuota.UseVisualStyleBackColor = true;
            this.svuota.Click += new System.EventHandler(this.svuota_Click);
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(160, 284);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(75, 23);
            this.modifica.TabIndex = 4;
            this.modifica.Text = "Modifica";
            this.modifica.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(391, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(397, 426);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(285, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.svuota);
            this.Controls.Add(this.cancella);
            this.Controls.Add(this.stampa);
            this.Controls.Add(this.salva);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.Button stampa;
        private System.Windows.Forms.Button cancella;
        private System.Windows.Forms.Button svuota;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

