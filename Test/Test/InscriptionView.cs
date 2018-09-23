using System;
using System.Windows.Forms;


namespace Test
{
    public partial class InscriptionView : Form
    {
        public User user = new User();
        MainView accueil = new MainView();

        public InscriptionView()
        {
            InitializeComponent();

            this.ResizeRedraw = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            accueil.Show();
            this.Close();
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
           user.Name = tb_Name.Text;
        }

        private void tb_Lastname_TextChanged(object sender, EventArgs e)
        {
          user.Prenom = tb_Lastname.Text;
        }

        private void tb_Email_TextChanged(object sender, EventArgs e)
        {
            user.Email = tb_Email.Text;
        }

        private void spin_Taille_ValueChanged(object sender, EventArgs e)
        {
            user.Taille = spin_Taille.Value; 
        }

        private void numeric_Age_ValueChanged(object sender, EventArgs e)
        {
            user.Age = numeric_Age.Value;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            user.Password = tb_Password.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(tb_Email.Text)) || (string.IsNullOrEmpty(tb_Password.Text)) )
            {
                MessageBox.Show("Saisir obligatoirement une adresse mail et un mot de passe valide");
            }
            else
            {
                MessageBox.Show("Inscription validée");
                this.Hide();
                accueil.Show();
            }
        }

        private void InscriptionView_Load(object sender, EventArgs e)
        {
            this.FormClosed += InscriptionView_FormClosed;
        }

        private void InscriptionView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
