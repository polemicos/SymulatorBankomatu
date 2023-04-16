
namespace Bankomat_Rakovich
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNaKoncie = new System.Windows.Forms.Label();
            this.textBoxStanKonta = new System.Windows.Forms.TextBox();
            this.buttonAdministrator = new System.Windows.Forms.Button();
            this.labelPodajKwote = new System.Windows.Forms.Label();
            this.textBoxKwota = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.richTextBoxWydano = new System.Windows.Forms.RichTextBox();
            this.labelNieWpisanaKwota = new System.Windows.Forms.Label();
            this.labelNiemaSrodkow = new System.Windows.Forms.Label();
            this.labelMalo = new System.Windows.Forms.Label();
            this.labelBrakBanknot = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNaKoncie
            // 
            this.labelNaKoncie.AutoSize = true;
            this.labelNaKoncie.Location = new System.Drawing.Point(179, 147);
            this.labelNaKoncie.Name = "labelNaKoncie";
            this.labelNaKoncie.Size = new System.Drawing.Size(82, 13);
            this.labelNaKoncie.TabIndex = 0;
            this.labelNaKoncie.Text = "W bankomacie:";
            // 
            // textBoxStanKonta
            // 
            this.textBoxStanKonta.Location = new System.Drawing.Point(267, 144);
            this.textBoxStanKonta.Name = "textBoxStanKonta";
            this.textBoxStanKonta.ReadOnly = true;
            this.textBoxStanKonta.Size = new System.Drawing.Size(107, 20);
            this.textBoxStanKonta.TabIndex = 1;
            // 
            // buttonAdministrator
            // 
            this.buttonAdministrator.Location = new System.Drawing.Point(473, 12);
            this.buttonAdministrator.Name = "buttonAdministrator";
            this.buttonAdministrator.Size = new System.Drawing.Size(75, 23);
            this.buttonAdministrator.TabIndex = 2;
            this.buttonAdministrator.Text = "Admin";
            this.buttonAdministrator.UseVisualStyleBackColor = true;
            this.buttonAdministrator.Click += new System.EventHandler(this.buttonAdministrator_Click);
            // 
            // labelPodajKwote
            // 
            this.labelPodajKwote.AutoSize = true;
            this.labelPodajKwote.Location = new System.Drawing.Point(179, 188);
            this.labelPodajKwote.Name = "labelPodajKwote";
            this.labelPodajKwote.Size = new System.Drawing.Size(126, 13);
            this.labelPodajKwote.TabIndex = 3;
            this.labelPodajKwote.Text = "Podaj kwotę do wydania:";
            // 
            // textBoxKwota
            // 
            this.textBoxKwota.Location = new System.Drawing.Point(182, 215);
            this.textBoxKwota.Name = "textBoxKwota";
            this.textBoxKwota.Size = new System.Drawing.Size(123, 20);
            this.textBoxKwota.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(311, 215);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(63, 20);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Zatwierdź";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // richTextBoxWydano
            // 
            this.richTextBoxWydano.Location = new System.Drawing.Point(182, 267);
            this.richTextBoxWydano.Name = "richTextBoxWydano";
            this.richTextBoxWydano.ReadOnly = true;
            this.richTextBoxWydano.Size = new System.Drawing.Size(192, 120);
            this.richTextBoxWydano.TabIndex = 6;
            this.richTextBoxWydano.Text = "";
            // 
            // labelNieWpisanaKwota
            // 
            this.labelNieWpisanaKwota.AutoSize = true;
            this.labelNieWpisanaKwota.ForeColor = System.Drawing.Color.Red;
            this.labelNieWpisanaKwota.Location = new System.Drawing.Point(182, 242);
            this.labelNieWpisanaKwota.Name = "labelNieWpisanaKwota";
            this.labelNieWpisanaKwota.Size = new System.Drawing.Size(71, 13);
            this.labelNieWpisanaKwota.TabIndex = 7;
            this.labelNieWpisanaKwota.Text = "Wpisz kwotę!";
            this.labelNieWpisanaKwota.Visible = false;
            // 
            // labelNiemaSrodkow
            // 
            this.labelNiemaSrodkow.AutoSize = true;
            this.labelNiemaSrodkow.ForeColor = System.Drawing.Color.Red;
            this.labelNiemaSrodkow.Location = new System.Drawing.Point(182, 242);
            this.labelNiemaSrodkow.Name = "labelNiemaSrodkow";
            this.labelNiemaSrodkow.Size = new System.Drawing.Size(136, 13);
            this.labelNiemaSrodkow.TabIndex = 8;
            this.labelNiemaSrodkow.Text = "Nie ma środków na koncie!";
            this.labelNiemaSrodkow.Visible = false;
            // 
            // labelMalo
            // 
            this.labelMalo.AutoSize = true;
            this.labelMalo.ForeColor = System.Drawing.Color.Red;
            this.labelMalo.Location = new System.Drawing.Point(182, 242);
            this.labelMalo.Name = "labelMalo";
            this.labelMalo.Size = new System.Drawing.Size(107, 13);
            this.labelMalo.TabIndex = 9;
            this.labelMalo.Text = "Mała kwota wypłaty!";
            this.labelMalo.Visible = false;
            // 
            // labelBrakBanknot
            // 
            this.labelBrakBanknot.AutoSize = true;
            this.labelBrakBanknot.ForeColor = System.Drawing.Color.Red;
            this.labelBrakBanknot.Location = new System.Drawing.Point(182, 242);
            this.labelBrakBanknot.Name = "labelBrakBanknot";
            this.labelBrakBanknot.Size = new System.Drawing.Size(145, 13);
            this.labelBrakBanknot.TabIndex = 10;
            this.labelBrakBanknot.Text = "Brak banknot. Przepraszamy.";
            this.labelBrakBanknot.Visible = false;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.ForeColor = System.Drawing.Color.Red;
            this.labelFormat.Location = new System.Drawing.Point(182, 242);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(150, 13);
            this.labelFormat.TabIndex = 11;
            this.labelFormat.Text = "Nieprawidłowy format danych!";
            this.labelFormat.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.labelBrakBanknot);
            this.Controls.Add(this.labelMalo);
            this.Controls.Add(this.labelNiemaSrodkow);
            this.Controls.Add(this.labelNieWpisanaKwota);
            this.Controls.Add(this.richTextBoxWydano);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxKwota);
            this.Controls.Add(this.labelPodajKwote);
            this.Controls.Add(this.buttonAdministrator);
            this.Controls.Add(this.textBoxStanKonta);
            this.Controls.Add(this.labelNaKoncie);
            this.Name = "Form1";
            this.Text = "Bankomat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaKoncie;
        private System.Windows.Forms.TextBox textBoxStanKonta;
        private System.Windows.Forms.Button buttonAdministrator;
        private System.Windows.Forms.Label labelPodajKwote;
        private System.Windows.Forms.TextBox textBoxKwota;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.RichTextBox richTextBoxWydano;
        private System.Windows.Forms.Label labelNieWpisanaKwota;
        private System.Windows.Forms.Label labelNiemaSrodkow;
        private System.Windows.Forms.Label labelMalo;
        private System.Windows.Forms.Label labelBrakBanknot;
        private System.Windows.Forms.Label labelFormat;
    }
}

