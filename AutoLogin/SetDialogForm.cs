using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLogin
{
    public partial class setDialogForm : Form
    {
        public setDialogForm()
        {
            InitializeComponent();
        }

        private void setDialog_Load(object sender, EventArgs e)
        {
            username.Text = Properties.Settings.Default.user;
            password.Text = Properties.Settings.Default.password;
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.user = username.Text;
            Properties.Settings.Default.password = password.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
