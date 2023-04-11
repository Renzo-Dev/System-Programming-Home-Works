using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Задание 3:
    //
    // Разработайте приложение, которое умеет запускать дочерний процесс и
    // передавать ему аргументы командной строки.
    // Аргументами должны быть два числа и операция, которую необходимо выполнить.
    // Например, аргументы:
    //  7
    //  3
    //  +
    // Дочерний процесс должен отобразить аргументы и вывести результат
    // сложения '10' на экран.

    // запускаем дочерний процесс

    public partial class Task3 : Form
    {
        private Process _process;

        public Task3()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path =
                @"C:\Users\Administrator\source\repos\WindowsFormsApp1\ConsoleShowArg\bin\Debug\ConsoleShowArg.exe";
            _process = new Process();
            _process.StartInfo.FileName = path;
            _process.StartInfo.Arguments = $"{textBox1.Text} {textBox2.Text} {textBox3.Text}"; //"5 + 4";
            _process.Start();
        }
    }
}