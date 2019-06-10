using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void HideUser()
        {
            panel_adduser.Enabled = false;
            panel_deleteuser.Enabled = false;

        }
        private void User_Load(object sender, EventArgs e)
        {
            HideUser();
        }

        private void butt_adduser_Click(object sender, EventArgs e)
        {
           
        }

        private void butt_deleteuser_Click(object sender, EventArgs e)
        {
            
        }

        private void butt_addusermain_Click(object sender, EventArgs e)
        {
            HideUser();
            panel_adduser.Enabled = true;
        }

        private void butt_deleteusermain_Click(object sender, EventArgs e)
        {
            HideUser();
            panel_deleteuser.Enabled = true;
        }
    }
}
