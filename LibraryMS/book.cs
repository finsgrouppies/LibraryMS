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
    public partial class panel_book : UserControl
    {
        public panel_book()
        {
            InitializeComponent();
        }

        public void DisablePanels()
        {
            panel_addbook.Enabled = false;
            panel_deletebook.Enabled = false;


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butt_addbookmain_Click(object sender, EventArgs e)
        {
            DisablePanels();
            panel_addbook.Enabled = true;

        }

        private void butt_deletebookmain_Click(object sender, EventArgs e)
        {
            DisablePanels();

            panel_deletebook.Enabled = true;

        }

        private void panel_book_Load(object sender, EventArgs e)
        {
            DisablePanels();
        }
    }
}
