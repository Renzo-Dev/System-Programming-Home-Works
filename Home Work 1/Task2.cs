using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Task2 : Form
    {
        private IntPtr hWnd = IntPtr.Zero;

        public Task2()
        {
            InitializeComponent();
            bChTitle.Visible = false;
            tbChTitle.Visible = false;
            BClose.Visible = false;
        }

        // Разработайте приложение, которое использует унаследованный код.
        // необходимо воспользоваться функцией FindWindow(поиск окна в
        // системе), SendMessage(отправка сообщений) из Windows
        // Приложение должно осуществить поиск окна из вашего оконного
        // приложения(можно реализовать его с помощью Windows Forms и
        // т.п.). Если окно найдено, необходимо отправить ему
        // сообщение в зависимости от выбора пользователя:
        //  об изменении заголовка окна на заголовок, введенный пользователем;
        //  о закрытии окна;
        //  ваш вариант.

        private void BFindWindow_Click(object sender, EventArgs e)
        {
            if (tbEntTitleWindow.Text.Length != 0)
            {
                hWnd = Form1.FindWindow(null, tbEntTitleWindow.Text);
                if (hWnd != IntPtr.Zero)
                {
                    ResultBox.BackColor = Color.Green;
                    bChTitle.Visible = true;
                    tbChTitle.Visible = true;
                    BClose.Visible = true;
                }
                else
                {
                    ResultBox.BackColor = Color.Red;
                    bChTitle.Visible = false;
                    tbChTitle.Visible = false;
                    BClose.Visible = false;
                }
            }
        }

        private void bChTitle_Click(object sender, EventArgs e)
        {
            if (tbChTitle.Text.Length > 0)
            {
                Form1.SendMessage(hWnd, Form1.WM_SETTEXT, null, tbChTitle.Text);
                tbEntTitleWindow.Text = tbChTitle.Text;
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Form1.SendMessage(hWnd, Form1.WM_CLOSE, null, null);
            ResultBox.BackColor = Color.Red;
            bChTitle.Visible = false;
            tbChTitle.Visible = false;
            BClose.Visible = false;
        }

        private void Task2_Load(object sender, EventArgs e)
        {

        }
    }
}