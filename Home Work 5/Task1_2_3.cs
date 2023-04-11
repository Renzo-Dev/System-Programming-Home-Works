using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Home_Work_5
{
    //  Задание 1:

    //  Создайте оконное приложение, которое использует механизм задач
    //  (класс "Task"). Пользователь вводит в текстовое поле некоторый текст.
    //  После нажатия на кнопку приложение должно проанализировать текст и
    //  вывести отчет.Отчет содержит информацию о:
    //   Количество предложений.
    //   Количество символов.
    //   Количество слов.
    //   Количество вопросительных предложений.
    //   Количество восклицательных предложений.

    //  Отчет, в зависимости от выбора пользователя, отображается на экране
    //  или сохраняется в файле.

    //  Задание 2:

    //  Добавьте к первому заданию возможность остановки и
    //  повторного запуска анализа текста.

    //  Задание 3:

    //  Добавьте к первой задаче возможность выбора типа
    //  информации, содержащейся в отчете.Например, пользователь может
    //  выбрать, что его интересует только количество предложений и слов.

    public partial class Task1_2_3 : Form
    {
        Task tWords = null;
        Task tSymbol = null;
        Task tSentence = null;

        public Task1_2_3()
        {
            InitializeComponent();
            DGV.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
        }

        private void Task123_Load(object sender, EventArgs e)
        {
            DGV.Rows.Add();
            DGV.Rows.Add();
            DGV.Rows.Add();
            DGV.Rows.Add();
            DGV.Rows.Add();

            DGV.Rows[0].Cells[0].Value = "Кол. слов";
            DGV.Rows[1].Cells[0].Value = "Кол. символов";
            DGV.Rows[2].Cells[0].Value = "Кол. предложений";
            DGV.Rows[3].Cells[0].Value = "Кол. вопрос.предложений";
            DGV.Rows[4].Cells[0].Value = "Кол. воск.предложений";

            DGV.Rows[0].Cells[1].Value = 0;
            DGV.Rows[1].Cells[1].Value = 0;
            DGV.Rows[2].Cells[1].Value = 0;
            DGV.Rows[3].Cells[1].Value = 0;
            DGV.Rows[4].Cells[1].Value = 0;
            DGV.ClearSelection();
        }

        private void CountWords()
        {
            if (ckbWord.Checked == true)
            {
                string[] st = tbText.Text.Split(' ');
                int count = 0;
                foreach (string s in st)
                {
                    if (s != "?" && s != "!" && s != "." && s != "," && s != "")
                    {
                        count++;
                    }
                }

                DGV.Rows[0].Cells[1].Value = count;
            }
        }

        private void CountSentence()
        {
            if (ckbSentence.Checked == true)
            {
                int countQ = 0; // ?
                int countExc = 0; // !
                int countS = 0; // .

                foreach (var word in tbText.Text)
                {
                    if (word == '!')
                    {
                        countExc++;
                    }

                    if (word == '.')
                    {
                        countS++;
                    }

                    if (word == '?')
                    {
                        countQ++;
                    }

                    DGV.Rows[2].Cells[1].Value = countS + countQ + countExc;
                    DGV.Rows[3].Cells[1].Value = countQ;
                    DGV.Rows[4].Cells[1].Value = countExc;
                }
            }
        }

        private void CountSymbol()
        {
            if (ckbSymbol.Checked == true)
            {
                if (Convert.ToInt32(DGV.Rows[1].Cells[1].Value) < tbText.Text.Length)
                {
                    DGV.Rows[1].Cells[1].Value = tbText.Text.Length;
                }

                if (Convert.ToInt32(DGV.Rows[1].Cells[1].Value) > tbText.Text.Length)
                {
                    DGV.Rows[1].Cells[1].Value = tbText.Text.Length;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parallel.Invoke(CountWords, CountSymbol, CountSentence);
        }
    }
}
