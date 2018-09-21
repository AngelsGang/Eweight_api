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
    public partial class InscriptionView : Form
    {
        public User user = new User();

        public InscriptionView()
        {
            InitializeComponent();

            this.ResizeRedraw = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(user.Name + user.Prenom);
        }


    }
}
