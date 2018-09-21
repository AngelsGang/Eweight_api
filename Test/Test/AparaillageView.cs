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
    public partial class AparaillageView : Form
    {
        Appareils objectConnected = new Appareils();
        

        public AparaillageView()
        {
            InitializeComponent();
            
        }

        private void Lv_Appareil_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AparaillageView_Load(object sender, EventArgs e)
        {

            foreach (var objet in objectConnected.ListAppareils)
            {
                
                Lv_Appareil.Items.Add(objet);
            }
        }
    }
}
