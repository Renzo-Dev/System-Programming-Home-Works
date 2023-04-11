using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PanelForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PanelForm(new Task1());
        }

        private void bTask2_Click(object sender, EventArgs e)
        {
            PanelForm(new Task2());
        }

        private void bTask3_Click(object sender, EventArgs e)
        {
            PanelForm(new Task3());
        }

        private void bTask4_Click(object sender, EventArgs e)
        {
            PanelForm(new Task4());
        }
    }
}