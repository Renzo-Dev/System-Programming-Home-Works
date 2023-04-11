using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Task3 : Form
    {
        private const uint SimpleBeep = 0xFFFFFFFF;
        private const uint WindowsCriticalStop = 0x00000010;
        private const uint WindowsAsterisk = 0x00000040;
        private const uint WindowsQuestion = 0x00000020;
        private const uint WindowsExclamation = 0x00000030;
        private const uint WindowsDefaultBeep = 0x00000000;

        public Task3()
        {
            InitializeComponent();
            LBSeelctSound.SelectionMode = SelectionMode.One;
            MesBeepPanel.Visible = false;
        }

        // Разработайте приложение, которое использует унаследованный код.Вам 
        // необходимо воспользоваться функциями Beep и MessageBeep из
        // Windows API.С помощью импортированных функций сгенерируйте
        // набор звуковых сигналов через определенные интервалы времени

        private void Task3_Load(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (RbBeep.Checked)
            {
                for (int i = dgvListSounds.Rows.Count; i != 0; i--)
                {
                    Form1.Beep(Convert.ToUInt32(dgvListSounds["FreqColumn", i - 1].Value.ToString()),
                        Convert.ToUInt32(dgvListSounds["DurationColumn", i - 1].Value.ToString()));
                    dgvListSounds.Rows.RemoveAt(i - 1);
                    dgvListSounds.Refresh();
                }
            }
            else if (RbMesBeep.Checked)
            {
                if (LBSeelctSound.SelectedIndex == 0)
                {
                    Form1.MessageBeep(SimpleBeep);
                }

                if (LBSeelctSound.SelectedIndex == 1)
                {
                    Form1.MessageBeep(WindowsAsterisk);
                }

                if (LBSeelctSound.SelectedIndex == 2)
                {
                    Form1.MessageBeep(WindowsCriticalStop);
                }

                if (LBSeelctSound.SelectedIndex == 3)
                {
                    Form1.MessageBeep(WindowsQuestion);
                }

                if (LBSeelctSound.SelectedIndex == 4)
                {
                    Form1.MessageBeep(WindowsExclamation);
                }

                if (LBSeelctSound.SelectedIndex == 5)
                {
                    Form1.MessageBeep(WindowsDefaultBeep);
                }
            }
        }

        private void check(object sender, EventArgs e)
        {
            if (RbMesBeep.Checked)
            {
                MesBeepPanel.Visible = true;
                BeepPanel.Visible = false;
                dgvListSounds.Visible = false;
            }
            else
            {
                MesBeepPanel.Visible = false;
                BeepPanel.Visible = true;
                dgvListSounds.Visible = true;
            }
        }

        private void CheckNumber(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if (Char.IsDigit(e.KeyChar))
                {
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int r = dgvListSounds.Rows.Add();
            dgvListSounds.Rows[r].Cells["FreqColumn"].Value = TBFreq.Text;
            dgvListSounds.Rows[r].Cells["DurationColumn"].Value = TBDuration.Text;
        }

        private void bPlayPanel_Click(object sender, EventArgs e)
        {
            Form1.Beep(Convert.ToUInt32(TBFreq.Text), Convert.ToUInt32(TBDuration.Text));
        }
    }
}