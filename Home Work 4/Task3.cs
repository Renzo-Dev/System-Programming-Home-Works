using System;
using System.Threading;
using System.Windows.Forms;

namespace Home_Work_4
{
    // Задание 3:
    //
    // Создайте приложение для подсчета всех чисел Фибоначчи от 0 до
    // предела, указанного пользователем.
    // Используйте оконный интерфейс и механизмы асинхронности.
    public partial class Task3 : Form
    {
        object locker = new object();

        public Task3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate { lbFibonacchi1.Items.Clear(); });
            BeginInvoke((MethodInvoker)delegate { lbFibonacchi2.Items.Clear(); });

            Thread thread1 = new Thread(() => { GeneratorFebonacci(lbFibonacchi1); })
                { IsBackground = true };

            Thread thread2 = new Thread(() => { GeneratorFebonacci(lbFibonacchi2); })
                { IsBackground = true };


            thread1.Start();
            thread2.Start();
        }

        private void GeneratorFebonacci(ListBox llbFibonacchi)
        {
            lock (locker)
            {
                decimal valueF = 1;

                decimal maxValue = 0;

                if (Convert.ToDecimal(tbMaxF.Text) > 0)
                {
                    maxValue = Convert.ToDecimal(tbMaxF.Text);
                }

                for (decimal i = 1; i <= maxValue; i += valueF)
                {
                    if (llbFibonacchi.InvokeRequired)
                    {
                        var f = valueF;
                        BeginInvoke((MethodInvoker)delegate { llbFibonacchi.Items.Add(f); });
                    }

                    valueF = i - valueF;
                    Thread.Sleep(50);
                }
            }
        }
    }
}