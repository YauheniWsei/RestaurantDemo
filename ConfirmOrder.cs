using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rest0._1
{
    public partial class ConfirmOrder : Form
    {
        public ConfirmOrder()
        {
            InitializeComponent();
        }

        private void cancel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
