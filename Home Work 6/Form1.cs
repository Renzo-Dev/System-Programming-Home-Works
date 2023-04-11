using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// При двойном клике на потоке, поток перемещается в список ожидающих потоков, где он
// будет находиться до тех пор, пока в семафоре не освободится для него
// место. Как только такое место освободилось, поток перемещается из
// спи ска ожидания в список рабочих потоков и приступает к работе.
// Работа заключается в том, чтобы увеличивать локальный счетчик
// каждого потока на единицу в секунду и отображать это значение. При
// двойном клике по потоку в списке рабочих потоков - поток прекращает
// свою работу, удаляется из списка и освобождает место для очередного
// ожидающего потока. Количество свободных мест задается в счетчике.
// При изменении счетчика более "старые" потоки покидают список, если
// произошло уменьшение счетчика, или же добавляются новые
// "ожидающие" потоки при увеличении значения счетчика. Изменение
// размера формы происходит, диамически подстраиваясь под
// наибольшее количество потоков в каком-либо списке. Примерный вид
// приложения смотрите ниже (хотя собственная креативность
// приветствуется)

// 1. нажатие кнопки , создаем поток и помещается в первый список где находятся все созданные потоки. ( N = 1 )
// 2. При двойном клике , поток перемещается в список ожидающих потоков


namespace Home_Work_6
{
    public partial class Form1 : Form
    {
        private Semaphore _semaphore;
        private List<Thread> _threads;
        private int _threadID = 0;

        public Form1()
        {
            InitializeComponent();
            _threads = new List<Thread>();
            _semaphore = new Semaphore(3, 3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _threads.Add(new Thread(Increment)
            {
                Name = _threads.Count.ToString()
            });

            lbCreatedThreads.Items.Add($"Поток {_threads.Count} --> Создан");
        }

        private void Increment()
        {
            _semaphore.WaitOne();
            int id = _threadID;

            int index = 0;
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => { index = lbWorkedThreads.Items.Add(""); }));
            }

            // инкремент
            int counter = 0;

            while (true)
            {
                counter++;
                if (lbWorkedThreads.InvokeRequired)
                {
                    var counter1 = counter;
                    BeginInvoke(new Action(() => { lbWorkedThreads.Items[index] = $"Поток {id + 1} ->> {counter1}"; }));
                }

                Thread.Sleep(1000);
            }
        }

        private void AbortThreadsOnClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var thread in _threads)
            {
                thread.Abort();
            }
        }

        static int GetThreadIdOfListBox(string str)
        {
            string buffer = "";
            int spaceCount = 0;
            foreach (var ch in str)
            {
                if (ch == ' ')
                {
                    spaceCount++;
                }

                if (spaceCount == 1)
                {
                    buffer += ch;
                }

                if (spaceCount == 2)
                {
                    break;
                }
            }

            return Convert.ToInt32(buffer);
        }

        private void lbWorkedThreads_DoubleClick(object sender, EventArgs e)
        {
            int threadId = GetThreadIdOfListBox(lbWorkedThreads.SelectedItem.ToString());

            _threads[threadId - 1].Abort();
            _semaphore.Release();

            //_threadID = Convert.ToInt32(threadId) - 1;
            //_threads[_threadID].Abort();
            //_threads.RemoveAt(_threadID);
            //lbWorkedThreads.Items.RemoveAt(lbWorkedThreads.SelectedIndex);
        }

        private void lbCreatedThreads_DoubleClick_1(object sender, EventArgs e)
        {
            int.TryParse(string.Join("", lbCreatedThreads.SelectedItem.ToString().Where(char.IsDigit)), out _threadID);

            lbWaitThreads.Items.Add($"Поток {_threadID} --> Ожидает");
            lbCreatedThreads.Items.RemoveAt(lbCreatedThreads.SelectedIndex);
            _threadID--;
            _threads[_threadID].Start();
            Task.Run(() => { });
        }
    }
}