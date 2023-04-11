using System;
using System.Windows.Forms;

namespace Home_Work_4
{
    public partial class Form1 : Form
    {
        private Form _active = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void ChangePanel(Form form)
        {
            if (_active != null)
            {
                _active.Close();
            }
            _active = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void bTask1_Click(object sender, EventArgs e)
        {
            ChangePanel(new Task1());
        }

        private void bTask2_Click(object sender, EventArgs e)
        {
            ChangePanel(new Task2());
        }

        private void bTask3_Click(object sender, EventArgs e)
        {
            ChangePanel(new Task3());
        }

        private void bTask4_Click(object sender, EventArgs e)
        {
            ChangePanel(new Task4());
        }

        private void bTask5_Click(object sender, EventArgs e)
        {
            ChangePanel(new Task5());
        }
    }
}