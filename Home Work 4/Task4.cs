using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Home_Work_4
{
    public partial class Task4 : Form
    {
        //Задание 4:

        //  Создайте приложение для поиска слова в определенном файле.
        //  Слово и путь к файлу указываются пользователем.
        //  Для решения задачи используйте задачи используйте оконный интерфейс и асинхронность.
        //  По итогам поиска приложение должно показать, сколько раз слов встретилось в файле.

        private Stream _fileStream = null;
        private string _fileContent = null;
        private string[] _words = null;
        private readonly Mutex _mutex = new Mutex();

        public Task4()
        {
            InitializeComponent();
        }

        private void Task4_Load(object sender, EventArgs e)
        {
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                tbPathToFile.Text = openFileDialog.FileName;
                //Read the contents of the file into a stream
                _fileStream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(_fileStream))
                {
                    _fileContent = reader.ReadToEnd();
                    _words = _fileContent.Split(new char[] { ' ', ',' });
                }
            }

            tbWord1.Enabled = true;
            tbWord2.Enabled = true;
        }

        private void tbWord_TextChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => { find_Word(lCount1, tbWord1); })
            {
                IsBackground = true
            };
            thread.Start();
        }

        private void tbWord2_TextChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => { find_Word(lCount2, tbWord2); })
            {
                IsBackground = true
            };
            thread.Start();
        }

        private void find_Word(Label lbCount, TextBox tbWord)
        {
            _mutex.WaitOne();
            int counter = 0;
            foreach (var word in _words)
            {
                if (tbWord.Text == word.ToLower())
                    counter++;
                // display how many times the word "'morning'" appears in the text
                if (lbCount.InvokeRequired)
                {
                    BeginInvoke((MethodInvoker)delegate { lbCount.Text = counter.ToString(); });
                }
            }
            _mutex.ReleaseMutex();
        }
    }
}