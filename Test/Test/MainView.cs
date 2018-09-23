using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void bt_MainInscript_Click(object sender, EventArgs e)
        {
            InscriptionView inscription = new InscriptionView();
            
            inscription.Show();
            this.Hide();
        }

        private void b_MainConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Username.Text) || string.IsNullOrEmpty(tb_Password.Text))
            {
                MessageBox.Show("L'un des champs requis n'est pas complété.");
            }
            else
            {
                AparaillageView aparaillage = new AparaillageView();
                
                aparaillage.Show();
                this.Hide();
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            this.FormClosed += MainView_FormClosed;
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
