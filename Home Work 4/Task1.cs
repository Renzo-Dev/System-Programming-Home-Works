using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Home_Work_4
{
    // Задание 1:
    // Создайте приложение "Танцующие прогресс-бары". Приложение отображает
    // набор прогресс-баров.Их количество определяется пользователем.
    // После нажатия на кнопку прогресс-бары начинают
    // заполняться (величины процесса заполнения и цвет
    // определяются случайным образом). Используйте механизм
    // многопоточности.
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            // создаем N потоков для запуска прогресс баров
            Thread[] threads = new Thread[FLPBars.Controls.Count];
            List<ProgressBar> progressBars = new List<ProgressBar>();

            for (int i = 0; i < FLPBars.Controls.Count; i++)
            {
                progressBars.Add(FLPBars.Controls[i] as ProgressBar);
            }

            for (int i = 0; i < threads.Length; i++)
            {
                // инициализируем новый поток

                var i1 = i;
                threads[i] = new Thread(() =>
                {
                    for (; progressBars[i1].Value < progressBars[i1].Maximum;)
                    {
                        if (progressBars[i1].InvokeRequired)
                        {
                            BeginInvoke((MethodInvoker)delegate { progressBars[i1].PerformStep(); });
                        }

                        Thread.Sleep(100);
                    }
                })
                {
                    IsBackground = true
                };
                threads[i].Start();
            }
        }

        // динамически изменяем кол.прогресс баров в FLP
        private void tbNumBars_TextChanged(object sender, EventArgs e)
        {
            if (tbNumBars.Text.Length > 0)
            {
                if (Convert.ToInt32(tbNumBars.Text) > FLPBars.Controls.Count)
                {
                    Random rnd = new Random();
                    for (; Convert.ToInt32(tbNumBars.Text) > FLPBars.Controls.Count;)
                    {
                        FLPBars.Controls.Add(new ProgressBar()
                        {
                            Width = 174,
                            Height = 28,
                            Step = rnd.Next(1, 70),
                            Maximum = 500,
                            ForeColor = Color.FromArgb(new Random().Next(1, 255), new Random().Next(1, 255),
                                new Random().Next(1, 255))
                        });
                    }
                }

                if (Convert.ToInt32(tbNumBars.Text) < FLPBars.Controls.Count)
                {
                    for (; Convert.ToInt32(tbNumBars.Text) < FLPBars.Controls.Count;)
                    {
                        FLPBars.Controls.RemoveAt(Convert.ToInt32(tbNumBars.Text));
                    }
                }
            }
        }
    }
}