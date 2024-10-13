namespace Rad_sa_više_formi
{
    partial class FormUnosNovogStudenta
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
            this.txtime = new System.Windows.Forms.TextBox();
            this.txtprezime = new System.Windows.Forms.TextBox();
            this.txtindex = new System.Windows.Forms.TextBox();
            this.combosmjer = new System.Windows.Forms.ComboBox();
            this.dateTimePickerdatumrođ = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsnimi = new System.Windows.Forms.Button();
            this.btnotkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(49, 72);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(175, 22);
            this.txtime.TabIndex = 0;
            // 
            // txtprezime
            // 
            this.txtprezime.Location = new System.Drawing.Point(49, 180);
            this.txtprezime.Name = "txtprezime";
            this.txtprezime.Size = new System.Drawing.Size(175, 22);
            this.txtprezime.TabIndex = 1;
            // 
            // txtindex
            // 
            this.txtindex.Location = new System.Drawing.Point(388, 72);
            this.txtindex.Name = "txtindex";
            this.txtindex.Size = new System.Drawing.Size(175, 22);
            this.txtindex.TabIndex = 3;
            this.txtindex.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // combosmjer
            // 
            this.combosmjer.FormattingEnabled = true;
            this.combosmjer.Location = new System.Drawing.Point(49, 278);
            this.combosmjer.Name = "combosmjer";
            this.combosmjer.Size = new System.Drawing.Size(175, 24);
            this.combosmjer.TabIndex = 4;
            // 
            // dateTimePickerdatumrođ
            // 
            this.dateTimePickerdatumrođ.Location = new System.Drawing.Point(388, 179);
            this.dateTimePickerdatumrođ.Name = "dateTimePickerdatumrođ";
            this.dateTimePickerdatumrođ.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerdatumrođ.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Smjer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = " Broj indexa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datum rođenja";
            // 
            // btnsnimi
            // 
            this.btnsnimi.Location = new System.Drawing.Point(52, 340);
            this.btnsnimi.Name = "btnsnimi";
            this.btnsnimi.Size = new System.Drawing.Size(145, 38);
            this.btnsnimi.TabIndex = 11;
            this.btnsnimi.Text = "Snimi";
            this.btnsnimi.UseVisualStyleBackColor = true;
            this.btnsnimi.Click += new System.EventHandler(this.btnsnimi_Click);
            // 
            // btnotkazi
            // 
            this.btnotkazi.Location = new System.Drawing.Point(394, 338);
            this.btnotkazi.Name = "btnotkazi";
            this.btnotkazi.Size = new System.Drawing.Size(145, 43);
            this.btnotkazi.TabIndex = 12;
            this.btnotkazi.Text = "Ozkazi";
            this.btnotkazi.UseVisualStyleBackColor = true;
            this.btnotkazi.Click += new System.EventHandler(this.btnotkazi_Click);
            // 
            // FormUnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnotkazi);
            this.Controls.Add(this.btnsnimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerdatumrođ);
            this.Controls.Add(this.combosmjer);
            this.Controls.Add(this.txtindex);
            this.Controls.Add(this.txtprezime);
            this.Controls.Add(this.txtime);
            this.Name = "FormUnosNovogStudenta";
            this.Text = "UnosNovogStudenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.TextBox txtprezime;
        private System.Windows.Forms.TextBox txtindex;
        private System.Windows.Forms.ComboBox combosmjer;
        private System.Windows.Forms.DateTimePicker dateTimePickerdatumrođ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsnimi;
        private System.Windows.Forms.Button btnotkazi;
    }
}