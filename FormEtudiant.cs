using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ecole
{
    public partial class FormEtudiant : Form
    {
        Gestion_SchoolEntities1 contexte = new Gestion_SchoolEntities1 ();
        public FormEtudiant()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            etudiant etudiant = new etudiant(); 
            etudiant.prenom=txtprenom.Text;
            etudiant.nom=txtnom.Text;
            etudiant.credit = int.Parse(txtcredit.Text);
            etudiant.reglement = int.Parse(txtreglement.Text);
            etudiant.annescolaire=txtannee.Text;
            etudiant.idclasse = Convert.ToInt32(comboBox1.SelectedValue);
            contexte.etudiant.Add(etudiant);
            contexte.SaveChanges();
            MessageBox.Show("Ajout etudiant avec succé!");
            dataGridView1.DataSource= contexte.etudiant.ToList();

        }

        private void FormEtudiant_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contexte.etudiant.ToList();
            comboBox1.DataSource = contexte.classe.ToList();
            comboBox1.DisplayMember = "libelle";
            comboBox1.ValueMember = "id";

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtprenom.Text = "";
            txtnom.Text = "";
            txtcredit.Text = "";
            txtreglement.Text = "";
            txtannee.Text = "";
        }

        private void bntupadate_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtid.Text, out id))
            {
                etudiant etudiant = contexte.etudiant.Find(id);
                if (etudiant != null)
                {
                    etudiant.prenom = txtprenom.Text;
                    etudiant.nom = txtnom.Text;
                    etudiant.credit = int.Parse(txtcredit.Text);
                    etudiant.reglement = int.Parse(txtreglement.Text);
                    etudiant.annescolaire = txtannee.Text;
                    etudiant.idclasse = Convert.ToInt32(comboBox1.SelectedValue);
                    contexte.SaveChanges();
                    MessageBox.Show("Étudiant mis à jour avec succès!");
                    dataGridView1.DataSource = contexte.etudiant.ToList();
                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé avec cet ID.");
                }
            }
            else
            {
                MessageBox.Show("L'ID saisi n'est pas valide.");
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            int id;
            if (int.TryParse(txtid.Text, out id))
            {
                etudiant etudiant = contexte.etudiant.Find(id);
                if (etudiant != null)
                {
                    contexte.etudiant.Remove(etudiant);
                    contexte.SaveChanges();
                    MessageBox.Show("Étudiant supprimé avec succès!");
                    dataGridView1.DataSource = contexte.etudiant.ToList();
                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé avec cet ID.");
                }
            }
            else
            {
                MessageBox.Show("L'ID saisi n'est pas valide.");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int idClasse = Convert.ToInt32(comboBox1.SelectedValue);
            var etudiants = contexte.etudiant.Where(etu => etu.idclasse == idClasse).ToList();

            if (etudiants.Count > 0)
            {
                dataGridView1.DataSource = etudiants;
            }
            else
            {
                MessageBox.Show("Aucun étudiant trouvé dans cette classe.");
            }
           
        }

        private void btnyear_Click(object sender, EventArgs e)
        {
            string annee = txtannee.Text;
            var  etudiants = contexte.etudiant.Where(et => et.annescolaire == annee).ToList();

            if (etudiants.Count > 0)
            {
                dataGridView1.DataSource = etudiants;
            }
            else
            {
                MessageBox.Show("Aucun étudiant trouvé pour cette année scolaire.");
            }
        }
    }
}
