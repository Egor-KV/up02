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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_09ip213DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_09ip213DataSet.Service);
            EditButton.Enabled = false;
            RecordButton.Enabled = false;
            VIewButton.Enabled = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
            this.Hide();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            Record rec = new Record();
            rec.Show();
            this.Hide();
        }

        private void VIewButton_Click(object sender, EventArgs e)
        {
            View vi = new View();
            vi.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kodButton_Click(object sender, EventArgs e)
        {
            if (kodBox.Text == "0000")
            {
                EditButton.Enabled = true;
                RecordButton.Enabled = true;
                VIewButton.Enabled = true;

                kodBox.Text = "";
            }
            else
            {
                MessageBox.Show("Incorrected Password");
                kodBox.Text = "";
            }
        }

        private void EditButtonMouseHover(object sender, EventArgs e)
        {
            EditButton.BackColor = Color.FromArgb(4, 160, 255);
        }

        private void EditButtonMouseLeave(object sender, EventArgs e)
        {
            EditButton.BackColor = Color.FromArgb(231, 250, 191);
        }

        private void RecordButton_MouseHover(object sender, EventArgs e)
        {
            RecordButton.BackColor = Color.FromArgb(4, 160, 255);
        }

        private void RecordButton_MouseLeave(object sender, EventArgs e)
        {
            RecordButton.BackColor = Color.FromArgb(231, 250, 191);
        }

        private void VIewButton_MouseHover(object sender, EventArgs e)
        {
            VIewButton.BackColor = Color.FromArgb(4, 160, 255);
        }

        private void VIewButton_MouseLeave(object sender, EventArgs e)
        {
            VIewButton.BackColor = Color.FromArgb(231, 250, 191);
        }

        private void kodButton_MouseHover(object sender, EventArgs e)
        {
            kodButton.BackColor = Color.FromArgb(4, 160, 255);
        }

        private void kodButton_MouseLeave(object sender, EventArgs e)
        {
            kodButton.BackColor = Color.FromArgb(231, 250, 191);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
