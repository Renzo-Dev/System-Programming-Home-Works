using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Задача 1:
    //
    // Разработайте приложение, которое умеет запускать дочерний процесс и ждать
    // его завершения.Когда дочерний процесс завершен,
    // родительское приложение должно отобразить код завершения.

    // 1. Найти/задать путь к процессу (exe)
    // 2. Запустить процесс (Task)
    // 3. Завершить процесс
    // 4. Вывести код завершения процесса

    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\";
            // получаем путь к execute
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var process = Process.Start(openFileDialog.FileName);
                if (process != null)
                {
                    lProcesStatus.Text = @"Запущен";
                    lProcesStatus.ForeColor = Color.Green;
                    process.WaitForExit();
                    process.EnableRaisingEvents = true;
                    lExidCode.Text += ' ' + Convert.ToString(process.ExitCode);
                    if (process.HasExited)
                    {
                        lProcesStatus.Text = @"Завершён";
                        lProcesStatus.ForeColor = Color.Brown;
                    }
                }
            }
        }
    }
}