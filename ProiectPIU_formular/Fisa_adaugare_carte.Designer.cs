
namespace ProiectPIU_formular
{
    partial class Fisa_adaugare_carte
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
            this.titlu = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditura = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditura = new System.Windows.Forms.TextBox();
            this.lblStareCarte = new System.Windows.Forms.Label();
            this.lblElemente = new System.Windows.Forms.Label();
            this.Titlu_afisare = new System.Windows.Forms.Label();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.txtEroareNume = new System.Windows.Forms.Label();
            this.txtEroareAutor = new System.Windows.Forms.Label();
            this.txtEroareEditura = new System.Windows.Forms.Label();
            this.lblRaspunsCautare = new System.Windows.Forms.Label();
            this.lblRaspuns_cautare = new System.Windows.Forms.Label();
            this.lblInstructiuni = new System.Windows.Forms.Label();
            this.grElementeCarte = new System.Windows.Forms.GroupBox();
            this.ckbIntroducere = new System.Windows.Forms.CheckBox();
            this.ckbIlustratii = new System.Windows.Forms.CheckBox();
            this.ckbPostfata = new System.Windows.Forms.CheckBox();
            this.ckbPrefata = new System.Windows.Forms.CheckBox();
            this.grStareCarte = new System.Windows.Forms.GroupBox();
            this.rdbDeteriorata = new System.Windows.Forms.RadioButton();
            this.rdbIntacta = new System.Windows.Forms.RadioButton();
            this.rdbNoua = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDetalii = new System.Windows.Forms.ListBox();
            this.lblDetalii = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grElementeCarte.SuspendLayout();
            this.grStareCarte.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titlu.Location = new System.Drawing.Point(159, 9);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(174, 22);
            this.titlu.TabIndex = 0;
            this.titlu.Text = "Fișă adăugare carte";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNume.Location = new System.Drawing.Point(54, 66);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(103, 22);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume carte";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAutor.Location = new System.Drawing.Point(54, 112);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(105, 22);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Nume autor";
            // 
            // lblEditura
            // 
            this.lblEditura.AutoSize = true;
            this.lblEditura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditura.Location = new System.Drawing.Point(57, 157);
            this.lblEditura.Name = "lblEditura";
            this.lblEditura.Size = new System.Drawing.Size(72, 22);
            this.lblEditura.TabIndex = 3;
            this.lblEditura.Text = "Editura";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(192, 65);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(203, 22);
            this.txtNume.TabIndex = 4;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(192, 112);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(203, 22);
            this.txtAutor.TabIndex = 5;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtAutor_TextChanged);
            // 
            // txtEditura
            // 
            this.txtEditura.Location = new System.Drawing.Point(192, 157);
            this.txtEditura.Name = "txtEditura";
            this.txtEditura.Size = new System.Drawing.Size(203, 22);
            this.txtEditura.TabIndex = 6;
            this.txtEditura.TextChanged += new System.EventHandler(this.txtEditura_TextChanged);
            // 
            // lblStareCarte
            // 
            this.lblStareCarte.AutoSize = true;
            this.lblStareCarte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStareCarte.Location = new System.Drawing.Point(57, 190);
            this.lblStareCarte.Name = "lblStareCarte";
            this.lblStareCarte.Size = new System.Drawing.Size(0, 22);
            this.lblStareCarte.TabIndex = 7;
            // 
            // lblElemente
            // 
            this.lblElemente.AutoSize = true;
            this.lblElemente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblElemente.Location = new System.Drawing.Point(269, 190);
            this.lblElemente.Name = "lblElemente";
            this.lblElemente.Size = new System.Drawing.Size(0, 22);
            this.lblElemente.TabIndex = 8;
            // 
            // Titlu_afisare
            // 
            this.Titlu_afisare.AutoSize = true;
            this.Titlu_afisare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Titlu_afisare.Location = new System.Drawing.Point(631, 9);
            this.Titlu_afisare.Name = "Titlu_afisare";
            this.Titlu_afisare.Size = new System.Drawing.Size(130, 22);
            this.Titlu_afisare.TabIndex = 22;
            this.Titlu_afisare.Text = "Cărți existente";
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 16;
            this.lstAfisare.Location = new System.Drawing.Point(521, 65);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(410, 196);
            this.lstAfisare.TabIndex = 27;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(241, 507);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(139, 28);
            this.btnModifica.TabIndex = 31;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(101, 507);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(124, 28);
            this.btnCauta.TabIndex = 30;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(241, 463);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(139, 28);
            this.btnAfiseaza.TabIndex = 29;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(101, 463);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(124, 28);
            this.btnAdauga.TabIndex = 28;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // txtEroareNume
            // 
            this.txtEroareNume.AutoSize = true;
            this.txtEroareNume.Location = new System.Drawing.Point(189, 90);
            this.txtEroareNume.Name = "txtEroareNume";
            this.txtEroareNume.Size = new System.Drawing.Size(13, 17);
            this.txtEroareNume.TabIndex = 35;
            this.txtEroareNume.Text = "*";
            // 
            // txtEroareAutor
            // 
            this.txtEroareAutor.AutoSize = true;
            this.txtEroareAutor.Location = new System.Drawing.Point(189, 137);
            this.txtEroareAutor.Name = "txtEroareAutor";
            this.txtEroareAutor.Size = new System.Drawing.Size(13, 17);
            this.txtEroareAutor.TabIndex = 36;
            this.txtEroareAutor.Text = "*";
            // 
            // txtEroareEditura
            // 
            this.txtEroareEditura.AutoSize = true;
            this.txtEroareEditura.Location = new System.Drawing.Point(189, 182);
            this.txtEroareEditura.Name = "txtEroareEditura";
            this.txtEroareEditura.Size = new System.Drawing.Size(13, 17);
            this.txtEroareEditura.TabIndex = 37;
            this.txtEroareEditura.Text = "*";
            // 
            // lblRaspunsCautare
            // 
            this.lblRaspunsCautare.AutoSize = true;
            this.lblRaspunsCautare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRaspunsCautare.Location = new System.Drawing.Point(39, 544);
            this.lblRaspunsCautare.Name = "lblRaspunsCautare";
            this.lblRaspunsCautare.Size = new System.Drawing.Size(148, 22);
            this.lblRaspunsCautare.TabIndex = 38;
            this.lblRaspunsCautare.Text = "Raspuns Cautare";
            // 
            // lblRaspuns_cautare
            // 
            this.lblRaspuns_cautare.AutoSize = true;
            this.lblRaspuns_cautare.Location = new System.Drawing.Point(193, 549);
            this.lblRaspuns_cautare.Name = "lblRaspuns_cautare";
            this.lblRaspuns_cautare.Size = new System.Drawing.Size(13, 17);
            this.lblRaspuns_cautare.TabIndex = 39;
            this.lblRaspuns_cautare.Text = "*";
            // 
            // lblInstructiuni
            // 
            this.lblInstructiuni.AutoSize = true;
            this.lblInstructiuni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstructiuni.Location = new System.Drawing.Point(54, 403);
            this.lblInstructiuni.Name = "lblInstructiuni";
            this.lblInstructiuni.Size = new System.Drawing.Size(369, 44);
            this.lblInstructiuni.TabIndex = 40;
            this.lblInstructiuni.Text = "                Pentru obtiunea \"Cauta\" \r\ncompletati campurile dentru adaugare ca" +
    "rte";
            // 
            // grElementeCarte
            // 
            this.grElementeCarte.Controls.Add(this.ckbIntroducere);
            this.grElementeCarte.Controls.Add(this.ckbIlustratii);
            this.grElementeCarte.Controls.Add(this.ckbPostfata);
            this.grElementeCarte.Controls.Add(this.ckbPrefata);
            this.grElementeCarte.Location = new System.Drawing.Point(270, 268);
            this.grElementeCarte.Name = "grElementeCarte";
            this.grElementeCarte.Size = new System.Drawing.Size(204, 122);
            this.grElementeCarte.TabIndex = 44;
            this.grElementeCarte.TabStop = false;
            // 
            // ckbIntroducere
            // 
            this.ckbIntroducere.AutoSize = true;
            this.ckbIntroducere.Location = new System.Drawing.Point(0, 95);
            this.ckbIntroducere.Name = "ckbIntroducere";
            this.ckbIntroducere.Size = new System.Drawing.Size(102, 21);
            this.ckbIntroducere.TabIndex = 19;
            this.ckbIntroducere.Text = "Introducere";
            this.ckbIntroducere.UseVisualStyleBackColor = true;
            this.ckbIntroducere.CheckedChanged += new System.EventHandler(this.ckbStare_CheckedChanged);
            // 
            // ckbIlustratii
            // 
            this.ckbIlustratii.AutoSize = true;
            this.ckbIlustratii.Location = new System.Drawing.Point(0, 67);
            this.ckbIlustratii.Name = "ckbIlustratii";
            this.ckbIlustratii.Size = new System.Drawing.Size(78, 21);
            this.ckbIlustratii.TabIndex = 18;
            this.ckbIlustratii.Text = "Ilustratii";
            this.ckbIlustratii.UseVisualStyleBackColor = true;
            this.ckbIlustratii.CheckedChanged += new System.EventHandler(this.ckbStare_CheckedChanged);
            // 
            // ckbPostfata
            // 
            this.ckbPostfata.AutoSize = true;
            this.ckbPostfata.Location = new System.Drawing.Point(0, 39);
            this.ckbPostfata.Name = "ckbPostfata";
            this.ckbPostfata.Size = new System.Drawing.Size(82, 21);
            this.ckbPostfata.TabIndex = 17;
            this.ckbPostfata.Text = "Postfata";
            this.ckbPostfata.UseVisualStyleBackColor = true;
            this.ckbPostfata.CheckedChanged += new System.EventHandler(this.ckbStare_CheckedChanged);
            // 
            // ckbPrefata
            // 
            this.ckbPrefata.AutoSize = true;
            this.ckbPrefata.Location = new System.Drawing.Point(0, 11);
            this.ckbPrefata.Name = "ckbPrefata";
            this.ckbPrefata.Size = new System.Drawing.Size(76, 21);
            this.ckbPrefata.TabIndex = 16;
            this.ckbPrefata.Text = "Prefata";
            this.ckbPrefata.UseVisualStyleBackColor = true;
            this.ckbPrefata.CheckedChanged += new System.EventHandler(this.ckbStare_CheckedChanged);
            // 
            // grStareCarte
            // 
            this.grStareCarte.Controls.Add(this.rdbDeteriorata);
            this.grStareCarte.Controls.Add(this.rdbIntacta);
            this.grStareCarte.Controls.Add(this.rdbNoua);
            this.grStareCarte.Location = new System.Drawing.Point(54, 268);
            this.grStareCarte.Name = "grStareCarte";
            this.grStareCarte.Size = new System.Drawing.Size(200, 108);
            this.grStareCarte.TabIndex = 43;
            this.grStareCarte.TabStop = false;
            // 
            // rdbDeteriorata
            // 
            this.rdbDeteriorata.AutoSize = true;
            this.rdbDeteriorata.Location = new System.Drawing.Point(23, 77);
            this.rdbDeteriorata.Name = "rdbDeteriorata";
            this.rdbDeteriorata.Size = new System.Drawing.Size(100, 21);
            this.rdbDeteriorata.TabIndex = 14;
            this.rdbDeteriorata.TabStop = true;
            this.rdbDeteriorata.Text = "Deteriorata";
            this.rdbDeteriorata.UseVisualStyleBackColor = true;
            // 
            // rdbIntacta
            // 
            this.rdbIntacta.AutoSize = true;
            this.rdbIntacta.Location = new System.Drawing.Point(24, 49);
            this.rdbIntacta.Name = "rdbIntacta";
            this.rdbIntacta.Size = new System.Drawing.Size(71, 21);
            this.rdbIntacta.TabIndex = 13;
            this.rdbIntacta.TabStop = true;
            this.rdbIntacta.Text = "Intacta";
            this.rdbIntacta.UseVisualStyleBackColor = true;
            // 
            // rdbNoua
            // 
            this.rdbNoua.AutoSize = true;
            this.rdbNoua.Location = new System.Drawing.Point(24, 21);
            this.rdbNoua.Name = "rdbNoua";
            this.rdbNoua.Size = new System.Drawing.Size(63, 21);
            this.rdbNoua.TabIndex = 12;
            this.rdbNoua.TabStop = true;
            this.rdbNoua.Text = "Noua";
            this.rdbNoua.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(266, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Elemente componente carte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(54, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Stare carte introdusa";
            // 
            // lstDetalii
            // 
            this.lstDetalii.FormattingEnabled = true;
            this.lstDetalii.ItemHeight = 16;
            this.lstDetalii.Location = new System.Drawing.Point(521, 370);
            this.lstDetalii.Name = "lstDetalii";
            this.lstDetalii.Size = new System.Drawing.Size(410, 196);
            this.lstDetalii.TabIndex = 45;
            // 
            // lblDetalii
            // 
            this.lblDetalii.AutoSize = true;
            this.lblDetalii.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetalii.Location = new System.Drawing.Point(517, 335);
            this.lblDetalii.Name = "lblDetalii";
            this.lblDetalii.Size = new System.Drawing.Size(118, 22);
            this.lblDetalii.TabIndex = 46;
            this.lblDetalii.Text = "Detalii Carte";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(386, 486);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 28);
            this.btnReset.TabIndex = 47;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Fisa_adaugare_carte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 637);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDetalii);
            this.Controls.Add(this.lstDetalii);
            this.Controls.Add(this.grElementeCarte);
            this.Controls.Add(this.grStareCarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInstructiuni);
            this.Controls.Add(this.lblRaspuns_cautare);
            this.Controls.Add(this.lblRaspunsCautare);
            this.Controls.Add(this.txtEroareEditura);
            this.Controls.Add(this.txtEroareAutor);
            this.Controls.Add(this.txtEroareNume);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.Titlu_afisare);
            this.Controls.Add(this.lblElemente);
            this.Controls.Add(this.lblStareCarte);
            this.Controls.Add(this.txtEditura);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblEditura);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.titlu);
            this.Name = "Fisa_adaugare_carte";
            this.Text = "Form1";
            this.grElementeCarte.ResumeLayout(false);
            this.grElementeCarte.PerformLayout();
            this.grStareCarte.ResumeLayout(false);
            this.grStareCarte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditura;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditura;
        private System.Windows.Forms.Label lblStareCarte;
        private System.Windows.Forms.Label lblElemente;
        private System.Windows.Forms.Label Titlu_afisare;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label txtEroareNume;
        private System.Windows.Forms.Label txtEroareAutor;
        private System.Windows.Forms.Label txtEroareEditura;
        private System.Windows.Forms.Label lblRaspunsCautare;
        private System.Windows.Forms.Label lblRaspuns_cautare;
        private System.Windows.Forms.Label lblInstructiuni;
        private System.Windows.Forms.GroupBox grElementeCarte;
        private System.Windows.Forms.CheckBox ckbIntroducere;
        private System.Windows.Forms.CheckBox ckbIlustratii;
        private System.Windows.Forms.CheckBox ckbPostfata;
        private System.Windows.Forms.CheckBox ckbPrefata;
        private System.Windows.Forms.GroupBox grStareCarte;
        private System.Windows.Forms.RadioButton rdbDeteriorata;
        private System.Windows.Forms.RadioButton rdbIntacta;
        private System.Windows.Forms.RadioButton rdbNoua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDetalii;
        private System.Windows.Forms.Label lblDetalii;
        private System.Windows.Forms.Button btnReset;
    }
}

