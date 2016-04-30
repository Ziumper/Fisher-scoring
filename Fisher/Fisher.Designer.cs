namespace Fisher
{
    partial class Fisher
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
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.rtbPrzedSeleckja = new System.Windows.Forms.RichTextBox();
            this.ofdDaneWczytaj = new System.Windows.Forms.OpenFileDialog();
            this.gBoxSystemDecyzyjny = new System.Windows.Forms.GroupBox();
            this.gBoxWyniki = new System.Windows.Forms.GroupBox();
            this.tBLiczbaAtrybutów = new System.Windows.Forms.TrackBar();
            this.btnWykonaj = new System.Windows.Forms.Button();
            this.rtbPoSelekcji = new System.Windows.Forms.RichTextBox();
            this.lbOpis = new System.Windows.Forms.Label();
            this.lbIloscAtrybutow = new System.Windows.Forms.Label();
            this.gBoxSystemDecyzyjny.SuspendLayout();
            this.gBoxWyniki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLiczbaAtrybutów)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(55, 219);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 0;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // rtbPrzedSeleckja
            // 
            this.rtbPrzedSeleckja.Location = new System.Drawing.Point(34, 33);
            this.rtbPrzedSeleckja.Name = "rtbPrzedSeleckja";
            this.rtbPrzedSeleckja.ReadOnly = true;
            this.rtbPrzedSeleckja.Size = new System.Drawing.Size(122, 163);
            this.rtbPrzedSeleckja.TabIndex = 1;
            this.rtbPrzedSeleckja.Text = "";
            // 
            // ofdDaneWczytaj
            // 
            this.ofdDaneWczytaj.FileName = "System Decyzyjny";
            // 
            // gBoxSystemDecyzyjny
            // 
            this.gBoxSystemDecyzyjny.Controls.Add(this.btnWczytaj);
            this.gBoxSystemDecyzyjny.Controls.Add(this.rtbPrzedSeleckja);
            this.gBoxSystemDecyzyjny.Location = new System.Drawing.Point(12, 12);
            this.gBoxSystemDecyzyjny.Name = "gBoxSystemDecyzyjny";
            this.gBoxSystemDecyzyjny.Size = new System.Drawing.Size(200, 269);
            this.gBoxSystemDecyzyjny.TabIndex = 3;
            this.gBoxSystemDecyzyjny.TabStop = false;
            this.gBoxSystemDecyzyjny.Text = "System Decyzyjny";
            // 
            // gBoxWyniki
            // 
            this.gBoxWyniki.Controls.Add(this.lbIloscAtrybutow);
            this.gBoxWyniki.Controls.Add(this.lbOpis);
            this.gBoxWyniki.Controls.Add(this.tBLiczbaAtrybutów);
            this.gBoxWyniki.Controls.Add(this.btnWykonaj);
            this.gBoxWyniki.Controls.Add(this.rtbPoSelekcji);
            this.gBoxWyniki.Location = new System.Drawing.Point(251, 12);
            this.gBoxWyniki.Name = "gBoxWyniki";
            this.gBoxWyniki.Size = new System.Drawing.Size(237, 269);
            this.gBoxWyniki.TabIndex = 4;
            this.gBoxWyniki.TabStop = false;
            this.gBoxWyniki.Text = "Selekcja Metodą Fishera";
            // 
            // tBLiczbaAtrybutów
            // 
            this.tBLiczbaAtrybutów.Location = new System.Drawing.Point(6, 208);
            this.tBLiczbaAtrybutów.Minimum = 1;
            this.tBLiczbaAtrybutów.Name = "tBLiczbaAtrybutów";
            this.tBLiczbaAtrybutów.Size = new System.Drawing.Size(123, 45);
            this.tBLiczbaAtrybutów.TabIndex = 2;
            this.tBLiczbaAtrybutów.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tBLiczbaAtrybutów.Value = 1;
            this.tBLiczbaAtrybutów.Scroll += new System.EventHandler(this.tBLiczbaAtrybutów_Scroll);
            // 
            // btnWykonaj
            // 
            this.btnWykonaj.Location = new System.Drawing.Point(156, 208);
            this.btnWykonaj.Name = "btnWykonaj";
            this.btnWykonaj.Size = new System.Drawing.Size(75, 23);
            this.btnWykonaj.TabIndex = 1;
            this.btnWykonaj.Text = "Wykonaj";
            this.btnWykonaj.UseVisualStyleBackColor = true;
            this.btnWykonaj.Click += new System.EventHandler(this.btnWykonaj_Click);
            // 
            // rtbPoSelekcji
            // 
            this.rtbPoSelekcji.Location = new System.Drawing.Point(49, 33);
            this.rtbPoSelekcji.Name = "rtbPoSelekcji";
            this.rtbPoSelekcji.ReadOnly = true;
            this.rtbPoSelekcji.Size = new System.Drawing.Size(133, 163);
            this.rtbPoSelekcji.TabIndex = 0;
            this.rtbPoSelekcji.Text = "";
            // 
            // lbOpis
            // 
            this.lbOpis.AutoSize = true;
            this.lbOpis.Location = new System.Drawing.Point(7, 239);
            this.lbOpis.Name = "lbOpis";
            this.lbOpis.Size = new System.Drawing.Size(90, 13);
            this.lbOpis.TabIndex = 3;
            this.lbOpis.Text = "Liczba atrybutów:";
            // 
            // lbIloscAtrybutow
            // 
            this.lbIloscAtrybutow.AutoSize = true;
            this.lbIloscAtrybutow.Location = new System.Drawing.Point(95, 239);
            this.lbIloscAtrybutow.Name = "lbIloscAtrybutow";
            this.lbIloscAtrybutow.Size = new System.Drawing.Size(13, 13);
            this.lbIloscAtrybutow.TabIndex = 4;
            this.lbIloscAtrybutow.Text = "1";
            // 
            // Fisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 332);
            this.Controls.Add(this.gBoxWyniki);
            this.Controls.Add(this.gBoxSystemDecyzyjny);
            this.MinimumSize = new System.Drawing.Size(377, 329);
            this.Name = "Fisher";
            this.Text = "Selekcja Atrybutów Metodą Fishera";
            this.gBoxSystemDecyzyjny.ResumeLayout(false);
            this.gBoxWyniki.ResumeLayout(false);
            this.gBoxWyniki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLiczbaAtrybutów)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPrzedSeleckja;
        private System.Windows.Forms.OpenFileDialog ofdDaneWczytaj;
        private System.Windows.Forms.GroupBox gBoxSystemDecyzyjny;
        private System.Windows.Forms.GroupBox gBoxWyniki;
        private System.Windows.Forms.RichTextBox rtbPoSelekcji;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnWykonaj;
        private System.Windows.Forms.TrackBar tBLiczbaAtrybutów;
        private System.Windows.Forms.Label lbOpis;
        private System.Windows.Forms.Label lbIloscAtrybutow;
    }
}

