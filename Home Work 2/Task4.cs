using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Задание 4:
    //
    // Разработайте приложение, которое умеет запускать дочерний процесс и
    // передавать ему аргументы командной строки.
    // Аргументами должны быть путь к файлу и слово для поиска.
    // Например,аргументы:
    //  E:\someFolder
    //  bicycle
    // Дочерний процесс должен отображать количество раз, сколько слово
    // 'bicycle' встречается в файле.

    public partial class Task4 : Form
    {
        private Process _process;

        public Task4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPath.Text.Length != 0 && tbSearchWord.Text.Length != 0)
            {
                _process = new Process();
                _process.StartInfo.FileName =
                    @"C:\Users\Administrator\source\repos\WindowsFormsApp1\ConsoleShowArgTask4\bin\Debug\ConsoleShowArgTask4.exe";
                _process.StartInfo.Arguments = $"{tbPath.Text} {tbSearchWord.Text}";
                _process.Start();
            }
        }
    }
}