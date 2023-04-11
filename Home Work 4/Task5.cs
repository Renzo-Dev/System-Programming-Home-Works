using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home_Work_4
{
    //  Задание 5:

    //  Создайте приложение для поиска слова в файлах определенной директории.
    //  Вход в поддиректории обязателен.Слово и путь к директории
    //  указываются пользователем. Для решения задачи
    //  используйте оконный интерфейс и асинхронность.
    //  По итогам поиска приложение должно показать отчет в
    //  итогам поиска приложение должно показать отчет в формате:
    //  Название файла: ......
    //  Путь к файлу: ....
    //  Количество вхождений слова: ....

    public partial class Task5 : Form
    {
        private List<string> _filesPaths = new List<string>(); // все пути к файлам в открытом каталоге
        private readonly Mutex _mutex = new Mutex();

        public Task5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            // открываем основной каталог
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (_filesPaths.Count > 0)
                {
                    _filesPaths.Clear();
                }

                GetListOfFilesSubDirectories(folderBrowserDialog.SelectedPath);
                tbWord.Enabled = true;
            }
        }

        // get a list of files and subdirectories
        public void GetListOfFilesSubDirectories(string targetDirectory)
        {
            // получаем список директорий в каталоге
            string[] fileEntries = Directory.GetFiles(targetDirectory, "*.txt");
            foreach (string filePath in fileEntries)
            {
                _filesPaths.Add(filePath);
                int num = DGV.Rows.Add();
                DGV.Rows[num].Cells[0].Value = Path.GetFileName(filePath);
                DGV.Rows[num].Cells[1].Value = filePath;
            }

            // получаем подкаталоги этого каталога
            string[] subDirectoryEntries = Directory.GetDirectories(targetDirectory);
            // ищем файлы и подкаталоги в подкаталогах
            foreach (string subDirectory in subDirectoryEntries)
            {
                GetListOfFilesSubDirectories(subDirectory);
            }
        }

        public int FindWord(string filePath)
        {
            _mutex.WaitOne();
            int counter = 0;
            string[] words = null;

            using (StreamReader reader = new StreamReader(filePath))
            {
                var fileContent = reader.ReadToEnd();
                words = fileContent.Split(new char[] { ' ', ',' });
            }

            foreach (var word in words)
            {
                if (tbWord.Text == word.ToLower())
                    counter++;
            }

            _mutex.ReleaseMutex();
            return counter;
        }

        private void tbWord_TextChanged(object sender, System.EventArgs e)
        {
            for (int i = 0; i < _filesPaths.Count; i++)
            {
                var i1 = i;
                Thread thread = new Thread(() =>
                {
                    DGV.Rows[i1].Cells[2].Value = FindWord(_filesPaths[i1]);
                })
                {
                    IsBackground = true
                };
                thread.Start();
            }
        }
    }
}