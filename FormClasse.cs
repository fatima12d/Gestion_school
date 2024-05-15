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
    public partial class FormClasse : Form
    {
        Gestion_SchoolEntities1 contexte = new Gestion_SchoolEntities1();
        public FormClasse()

        {
            InitializeComponent();
        }

        private void txtsave_Click(object sender, EventArgs e)
        {
            classe classe = new classe();
            classe.libelle = comboniveau.Text+combospecialite.Text;
            classe.niveau = comboniveau.Text;
            classe.specialite = combospecialite.Text;
            contexte.classe.Add(classe);
            contexte.SaveChanges();
            MessageBox.Show("Ajout de la classe reussie!");
            dataGridView1.DataSource = contexte.classe.ToList();

        }

        private void FormClasse_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contexte.classe.ToList();

        }
    }
}
