using System;
using System.Windows.Forms;

namespace Test
{
    public partial class AparaillageView : Form
    {
        Appareils objectConnected = new Appareils();
        MainView accueil = new MainView();

        public AparaillageView()
        {
            InitializeComponent();
        }

        private void AparaillageView_Load(object sender, EventArgs e)
        {

            foreach (var objet in objectConnected.ListAppareils)
            {
                Lv_Appareil.Items.Add(objet);
            }

            this.FormClosed += AparaillageView_FormClosed;
        }

        private void AparaillageView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            accueil.Show();
        }
    }
}
