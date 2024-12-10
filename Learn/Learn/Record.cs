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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void BuckButton_Click(object sender, EventArgs e)
        {
            Form MainF = Application.OpenForms[0];
            MainF.Show();
            this.Close();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_09ip213DataSet2.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter1.Fill(this.school_09ip213DataSet2.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_09ip213DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_09ip213DataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_09ip213DataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.school_09ip213DataSet1.Client);

        }

      

        private void RecordButton_MouseHover(object sender, EventArgs e)
        {
            RecordButton.BackColor = Color.FromArgb(4, 160, 255);
        }

        private void RecordButton_MouseLeave(object sender, EventArgs e)
        {
            RecordButton.BackColor = Color.FromArgb(231, 250, 191);
        }

        private void BuckButton_MouseHover(object sender, EventArgs e)
        {
            BuckButton.BackColor = Color.FromArgb(4, 160, 255);
        }

        private void BuckButton_MouseLeave(object sender, EventArgs e)
        {
            BuckButton.BackColor = Color.FromArgb(231, 250, 191);
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {

        }
        
        int TimeInSecunds(int h, int m)
        {
            return h *3600 + m * 60; 
        }

        void GetHourAndMinuts(int sec)
        {
            int h, m, totalMinuts;

            totalMinuts = sec / 60;
            h = totalMinuts / 60;
            m = totalMinuts % 60;

            textBox5.Text = Convert.ToString(h); //вычисление часов
            textBox4.Text = Convert.ToString(m); //вычисление минут
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            int ch, min, sec;
            ch = Convert.ToInt32(textBox1.Text);
            min = Convert.ToInt32(textBox2.Text);
            sec = TimeInSecunds(ch, min); //перевод начального времени в секунды

            int dur = Convert.ToInt32(textBox3.Text); //длит занятия

            sec+= dur; //время конца в секундах

            GetHourAndMinuts(sec);
            /*
            textBox5.Text = Convert.ToString((int)sec / 3600); //вычисление часов
            sec = sec % 3600;
            textBox4.Text = Convert.ToString((int)sec / 60); //вычисление минут 
            */

        }
    }
}
