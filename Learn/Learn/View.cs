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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void BuckButton_Click(object sender, EventArgs e)
        {
            Form MainF = Application.OpenForms[0];
            MainF.Show();
            this.Close();
        }

        private void View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_09ip213DataSet3.ClientService". При необходимости она может быть перемещена или удалена.
            this.clientServiceTableAdapter.Fill(this.school_09ip213DataSet3.ClientService);

        }

        private void MouseHover(object sender, EventArgs e)
        {
            BuckButton.BackColor = Color.FromArgb(4, 160, 255);

        }

        private void MouseLeave(object sender, EventArgs e)
        {
            BuckButton.BackColor = Color.FromArgb(231, 250, 191);
        }
    }
}
