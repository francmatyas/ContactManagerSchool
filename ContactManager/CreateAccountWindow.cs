using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class CreateAccountWindow : Form
    {
        public CreateAccountWindow()
        {
            InitializeComponent();
        }

        private void cancelAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
