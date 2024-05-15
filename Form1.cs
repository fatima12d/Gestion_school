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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtudiant form = new FormEtudiant();
            form.Show();
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClasse form = new FormClasse();
            form.Show();
        }
    }
}
