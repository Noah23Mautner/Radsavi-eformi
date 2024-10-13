namespace Rad_sa_više_formi
{
    partial class Form1
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
            this.listBoxstudenti = new System.Windows.Forms.ListBox();
            this.btnunesinovogstudenta = new System.Windows.Forms.Button();
            this.btnObrisiStudenta = new System.Windows.Forms.Button();
            this.btnobrisisvestudente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxstudenti
            // 
            this.listBoxstudenti.FormattingEnabled = true;
            this.listBoxstudenti.ItemHeight = 16;
            this.listBoxstudenti.Location = new System.Drawing.Point(12, 101);
            this.listBoxstudenti.Name = "listBoxstudenti";
            this.listBoxstudenti.Size = new System.Drawing.Size(362, 196);
            this.listBoxstudenti.TabIndex = 0;
            // 
            // btnunesinovogstudenta
            // 
            this.btnunesinovogstudenta.Location = new System.Drawing.Point(47, 30);
            this.btnunesinovogstudenta.Name = "btnunesinovogstudenta";
            this.btnunesinovogstudenta.Size = new System.Drawing.Size(158, 34);
            this.btnunesinovogstudenta.TabIndex = 1;
            this.btnunesinovogstudenta.Text = "Dodaj novog studenta";
            this.btnunesinovogstudenta.UseVisualStyleBackColor = true;
            this.btnunesinovogstudenta.Click += new System.EventHandler(this.btnunesinovogstudenta_Click);
            // 
            // btnObrisiStudenta
            // 
            this.btnObrisiStudenta.Location = new System.Drawing.Point(393, 177);
            this.btnObrisiStudenta.Name = "btnObrisiStudenta";
            this.btnObrisiStudenta.Size = new System.Drawing.Size(116, 33);
            this.btnObrisiStudenta.TabIndex = 2;
            this.btnObrisiStudenta.Text = "Obrisi studenta";
            this.btnObrisiStudenta.UseVisualStyleBackColor = true;
            this.btnObrisiStudenta.Click += new System.EventHandler(this.btnObrisiStudenta_Click);
            // 
            // btnobrisisvestudente
            // 
            this.btnobrisisvestudente.Location = new System.Drawing.Point(47, 347);
            this.btnobrisisvestudente.Name = "btnobrisisvestudente";
            this.btnobrisisvestudente.Size = new System.Drawing.Size(158, 34);
            this.btnobrisisvestudente.TabIndex = 3;
            this.btnobrisisvestudente.Text = "Obrisi sve studente";
            this.btnobrisisvestudente.UseVisualStyleBackColor = true;
            this.btnobrisisvestudente.Click += new System.EventHandler(this.btnobrisisvestudente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnobrisisvestudente);
            this.Controls.Add(this.btnObrisiStudenta);
            this.Controls.Add(this.btnunesinovogstudenta);
            this.Controls.Add(this.listBoxstudenti);
            this.Name = "Form1";
            this.Text = "Studenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxstudenti;
        private System.Windows.Forms.Button btnunesinovogstudenta;
        private System.Windows.Forms.Button btnObrisiStudenta;
        private System.Windows.Forms.Button btnobrisisvestudente;
    }
}

