using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Work_5
{
    public partial class Form1 : Form
    {
        Form active = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void ChangePanel(Form form)
        {
            if (active != null)
            {
                active.Close();
            }

            active = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ChangePanel(new Task1_2_3());
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            ChangePanel(new Task4_5());
        }
    }
}