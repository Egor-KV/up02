using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void BuckButton_Click(object sender, EventArgs e)
        {
            Form MainF = Application.OpenForms[0];
            MainF.Show();
            this.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BuckButton_MouseHover(object sender, EventArgs e)
        {
            BuckButton.BackColor = Color.FromArgb(4, 160, 255);
        }

        private void BuckButton_MouseLeave(object sender, EventArgs e)
        {
            BuckButton.BackColor = Color.FromArgb(231, 250, 191);
        }
    }
}
