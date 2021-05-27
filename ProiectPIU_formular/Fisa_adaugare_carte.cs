using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memorare_Date;
using System.Collections;
using Entitati_Biblioteca;

namespace ProiectPIU_formular
{
    public partial class Fisa_adaugare_carte : Form
    {
        IStocareData_Biblioteca administrareCarti = new Administrare_Biblioteca("Carti.txt");
        List<string> elementeCarte = new List<string>();

        bool valid = true;

        public Fisa_adaugare_carte()
        {
            InitializeComponent();
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {

            if (!DateIntrareValide())
            {
                lblNume.ForeColor = Color.Red;
                lblAutor.ForeColor = Color.Red;
                lblEditura.ForeColor = Color.Red;
                MessageBox.Show("Campuri obligatoriu de completat");
                resetareControale();
                return;
            }

            if (txtNume.Text.Length <= 15 && txtAutor.Text.Length <= 15 && txtEditura.Text.Length <= 10)
                valid = true;

            if(valid == false)
            {
                MessageBox.Show("Valori invalide");
                resetareControale();
                return;
            }

            Carte carte = new Carte(txtNume.Text, txtAutor.Text, txtEditura.Text);

            //set stare carte studiu
            //verificare radioButton selectat
            if (rdbNoua.Checked)
                carte.stare_carte=StareCarte.Noua;
            if (rdbIntacta.Checked)
                carte.stare_carte = StareCarte.Intacta;
            if (rdbDeteriorata.Checked)
                carte.stare_carte = StareCarte.Deteriorata;

            //adaugare elemente componente carte

            carte.elemente_componnte_carte = new List<string>();
            carte.elemente_componnte_carte.AddRange(elementeCarte);

            administrareCarti.AddCarte(carte);

            //resetarea controalelor pentru a introduce datele unei carti noi
            resetareControale();

        }
        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            lstAfisare.Items.Clear();
            var antetTabel = String.Format("{0,-10}\t{1,0}\t{2,15}\t{3,5}\n", "Cota", "Nume Carte", "Nume Autor", "Editura");
            lstAfisare.Items.Add(antetTabel);
            lstAfisare.Items.Add("__________________________________________________");

            List<Carte> carti = administrareCarti.GetCarti();
            foreach (Carte c in carti)
            {
                var linieTabel = String.Format("{0,-10}\t{1,0}\t\t{2,15}\t{3,5}\n", c.cota, c.nume_carte, c.nume_autor, c.editura);
                lstAfisare.Items.Add(linieTabel);
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (!DateIntrareValide())
            {
                lblNume.ForeColor = Color.Red;
                lblAutor.ForeColor = Color.Red;
                lblEditura.ForeColor = Color.Red;
                MessageBox.Show("Campuri obligatoriu de completat");
                resetareControale();
                return;
            }

            if (txtNume.Text.Length <= 15 && txtAutor.Text.Length <= 15 && txtEditura.Text.Length <= 10)
                valid = true;

            if (valid == false)
            {
                MessageBox.Show("Valori invalide");
                resetareControale();
                return;
            }

            Carte carte_modificata = administrareCarti.GetCarte(lstAfisare.SelectedIndex-1);
            carte_modificata.nume_carte = txtNume.Text;
            carte_modificata.nume_autor = txtAutor.Text;
            carte_modificata.editura = txtEditura.Text;

            administrareCarti.UpdateCarti(carte_modificata);

        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            Carte carte_selectata = administrareCarti.GetCarte(lstAfisare.SelectedIndex-1);
            if (carte_selectata != null)
            {
                lstDetalii.Items.Clear();
                txtNume.Text = carte_selectata.nume_carte;
                txtAutor.Text = carte_selectata.nume_autor;
                txtEditura.Text = carte_selectata.editura;
                string elemente="",disponibil="";
                for(int i = 0; i < carte_selectata.elemente_componnte_carte.Count; i++)
                {
                        elemente += carte_selectata.elemente_componnte_carte[i];
                        elemente += " ";
                }
                if (carte_selectata.disponibilitate == true)
                    disponibil = "DISPONIBILA";
                else
                    disponibil = "INDISPONIBILA";

                lstDetalii.Items.Add($"*Cartea selectata de dumneavoastra:");
                lstDetalii.Items.Add($"-este in stare: {carte_selectata.stare_carte},");
                lstDetalii.Items.Add($"-are componentele: {elemente},");
                lstDetalii.Items.Add($"-este: {disponibil}");
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            if (!DateIntrareValide())
            {
                lblNume.ForeColor = Color.Red;
                lblAutor.ForeColor = Color.Red;
                lblEditura.ForeColor = Color.Red;
                MessageBox.Show("Campuri obligatoriu de completat");
                resetareControale();
                return;
            }

            if (txtNume.Text.Length <= 15 && txtAutor.Text.Length <= 15 && txtEditura.Text.Length <= 10)
                valid = true;

            if (valid == false)
            {
                MessageBox.Show("Valori invalide");
                resetareControale();
                return;
            }

            int ok = 0;
            List<Carte> carti = administrareCarti.GetCarti();
            foreach (Carte c in carti)
            {
                if (c.nume_carte == txtNume.Text && c.nume_autor == txtAutor.Text && c.editura == txtEditura.Text)
                {
                    lstAfisare.SelectedIndex = c.cota+1;
                    lblRaspuns_cautare.Text = "Cartea cautata a fost gasita si selectata in lista";
                    ok = 1;
                    break;
                }
            }
            if(ok==0)
                lblRaspuns_cautare.Text = "Cartea cautata nu a fost gasita";

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            if (txtNume.Text.Length > 15)
            {
                txtEroareNume.Text = "MAXIM 15 CARACTERE";
                txtEroareNume.ForeColor = Color.Green;
                valid = false;
            }
            else
            {
                txtEroareNume.Text = "*";
                txtEroareNume.ForeColor = Color.Black;
                //valid = true;
            }

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

            if (txtAutor.Text.Length > 15)
            {
                txtEroareAutor.Text = "MAXIM 15 CARACTERE";
                txtEroareAutor.ForeColor = Color.Green;
                valid = false;
            }
            else
            {
                txtEroareAutor.Text = "*";
                txtEroareAutor.ForeColor = Color.Black;
                //valid = true;
            }
        }

        private void txtEditura_TextChanged(object sender, EventArgs e)
        {
            if (txtEditura.Text.Length > 10)
            {
                txtEroareEditura.Text = "MAXIM 10 CARACTERE";
                txtEroareEditura.ForeColor = Color.Green;
                valid = false;
            }
            else
            {
                txtEroareEditura.Text = "*";
                txtEroareEditura.ForeColor = Color.Black;
                //valid = true;
            }
        }

        private void ckbStare_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;
            string elementeSelectate = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                elementeCarte.Add(elementeSelectate);
            else
                elementeCarte.Remove(elementeSelectate);
        }

        bool DateIntrareValide()
        {
            if (txtNume.Text == String.Empty || txtAutor.Text == String.Empty || txtEditura.Text == String.Empty)
                return false;

            return true;
        }

        public void resetareControale()
        {
            txtNume.Text = txtAutor.Text = txtEditura.Text = string.Empty;
            rdbNoua.Checked = false;
            rdbIntacta.Checked = false;
            rdbDeteriorata.Checked = false;
            ckbIlustratii.Checked = false;
            ckbIntroducere.Checked = false;
            ckbPostfata.Checked = false;
            ckbPrefata.Checked = false;
            elementeCarte.Clear();
            
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetareControale();
            lstAfisare.Items.Clear();
            lstDetalii.Items.Clear();
        }
    }
}
