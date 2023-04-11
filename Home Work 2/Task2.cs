using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Задание 2:

    // Разработайте приложение, которое умеет запускать дочерний процесс.
    // В зависимости от выбора пользователя, родительское приложение должно ожидать
    // завершения дочернего процесса и отображать код завершения
    // или принудительно завершать работу дочернего процесса
    public partial class Task2 : Form
    {
        private ChangeControls _change;
        private readonly Process _process;

        public Task2()
        {
            InitializeComponent();
            _process = new Process();
        }

        public Process RunProcess()
        {
            _process.StartInfo.UseShellExecute = true;
            _process.StartInfo.FileName = openFileDialog.FileName;
            _process.EnableRaisingEvents = true;
            _process.Exited += install_HasExited;
            return _process;
        }

        private void install_HasExited(object sender, EventArgs e)
        {
            var p = sender as Process;

            _change = () =>
            {
                if (p != null) lExidCode.Text = ' ' + Convert.ToString(p.ExitCode);
            };

            lExidCode.Invoke(_change);
            if (p != null && p.HasExited)
            {
                _change = () =>
                {
                    lProcesStatus.Text = @"Завершён";
                    lProcesStatus.ForeColor = Color.Brown;
                };
                lProcesStatus.Invoke(_change);
                button2.Invoke(_change = () => { button2.Enabled = false; });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                if (RunProcess().Start())
                {
                    lProcesStatus.Text = @"Запущен";
                    lProcesStatus.ForeColor = Color.Green;
                    if (ckbWaitProcess.Checked)
                        _process.WaitForExit();
                    else
                        button2.Enabled = true;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_process != null) _process.Kill();
        }

        private void ckbWaitProcess_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbWaitProcess.Checked) button2.Enabled = false;
        }

        private delegate void ChangeControls();
    }
}