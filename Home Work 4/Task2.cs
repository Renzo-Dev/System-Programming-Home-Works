using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Home_Work_4
{
    // Задание 2:
    // Создайте эмуляцию конных гонок.В гонке принимают участие пять
    // лошадей.Каждая лошадь - это отдельный прогресс-бар.
    // После нажатия на кнопку "Старт" начинается гонка.
    // Скорость бега каждой лошади лошади определяется в процессе гонки случайным образом.
    // По итогам гонки необходимо показать таблицу результатов.
    // Используйте механизм многопоточности.
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, System.EventArgs e)
        {
            bStart.Enabled = false;
            Thread[] threads = new Thread[5];
            List<ProgressBar> progress = new List<ProgressBar>
            {
                hPgb1, hPgb2, hPgb3, hPgb4, hPgb5
            };
            foreach (var pr in progress)
            {
                pr.Value = 0;
                pr.Step = 10;
            }

            if (lbRaceResult.Items.Count > 0)
            {
                lbRaceResult.Items.Clear();
            }

            List<Label> lHSpeeds = new List<Label>
            {
                lH1Speed, lH2Speed, lH3Speed, lH4Speed, lH5Speed
            };
            foreach (var lhs in lHSpeeds)
            {
                lhs.Text = @"Speed";
            }

            Random rnd = new Random();
            // инициализируем потоки (5)
            for (int i = 0; i < 5; i++)
            {
                var i1 = i;

                threads[i] = new Thread(() =>
                {
                    if (progress[i1].InvokeRequired)
                    {
                        for (; progress[i1].Value < progress[i1].Maximum;)
                        {
                            BeginInvoke((MethodInvoker)delegate
                            {
                                progress[i1].Step = rnd.Next(1, 100);
                                lHSpeeds[i1].Text = Convert.ToString(progress[i1].Step);
                                progress[i1].PerformStep();
                            });
                            Thread.Sleep(100);
                        }

                        if (lbRaceResult.InvokeRequired)
                        {
                            BeginInvoke((MethodInvoker)delegate
                            {
                                lbRaceResult.Items.Add("Horse - " + Convert.ToInt32(i1 + 1));
                                if (lbRaceResult.Items.Count == 5)
                                {
                                    bStart.Enabled = true;
                                }
                            });
                        }
                    }
                })
                {
                    IsBackground = true
                };
                threads[i].Start();
            }
        }
    }
}