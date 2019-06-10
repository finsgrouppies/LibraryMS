using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }
        public void hidepanels()
        {
            panel_book.Visible = false;
            panel_user.Visible = false;
            panel_issue.Visible = false;
            panel_return.Visible = false;


        }

        private void butt_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "Bricksquad Library", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
          
        }

        private void butt_books_Click(object sender, EventArgs e)
        {
            hidepanels();
            panel_book.Visible = true;
       

        }

        private void butt_user_Click(object sender, EventArgs e)
        {
            hidepanels();
            panel_user.Visible = true;
        }

        private void butt_issue_Click(object sender, EventArgs e)
        {
            hidepanels();
            panel_issue.Visible = true;
        }

        private void butt_return_Click(object sender, EventArgs e)
        {
            hidepanels();
            panel_return.Visible = true;

        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            hidepanels();
            panel_issue.Visible = true;
        }
    }
}
