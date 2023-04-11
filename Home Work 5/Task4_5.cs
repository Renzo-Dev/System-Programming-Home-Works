using System.Windows.Forms;

namespace Home_Work_5
{
    // Задание 4:
    // Создайте оконное приложение, которое использует механизм задач
    // (класс "Task").
    // Пользователь вводит путь к директории источника и
    // директории приемника.
    // Приложение проверяет исходный файл на наличие файлов-двойников.
    // Все файлы-оригиналы переносятся в приемник.

    // Задание 5:
    // Добавьте к заданию 4 возможность генерации отчета о выполненных
    // действиях.

    public partial class Task4_5 : Form
    {
        public Task4_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (FBLSource.ShowDialog() == DialogResult.OK)
            {
                tbSource.Text = FBLSource.SelectedPath;
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (FBLReceiver.ShowDialog() == DialogResult.OK)
            {
                tbReceiver.Text = FBLReceiver.SelectedPath;
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {

        }
    }
}