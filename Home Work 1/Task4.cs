using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //  Разработайте оконное приложение с несколькими элементами управления
    //  (текстовые поля, кнопки и т.п.). Создайте другое приложение, которое будет
    //  использовать унаследованный код.
    //  Второе приложение должно изменять стили элементов управления в оконном приложении.
    //  Выбор стилей и механизмов остается на ваше усмотрение
    public partial class Task4 : Form
    {
        IntPtr _hWndFindPtr = IntPtr.Zero; // Дескриптор найденного окна
        private string[] _vStyles;         // коллекция стилей окна
        private string[] _vStylesEx;       // коллекция расширенных стилей окна

        public Task4()
        {
            InitializeComponent();
        }

        private void GetStylesWnd(bool style, bool styleEx)
        {
            if (style)
            {
                lsbStyles.Items.Clear();
                // Получает информацию об указанном окне
                IntPtr windowLongPtr = GetWindowLongPtr(_hWndFindPtr, WindowLongFlags.GWL_STYLE);
                // загружаем список стилей окна                
                _vStyles = Enum.GetNames(typeof(WindowStyle));
                // Приведение типов IntPTr num
                uint num = (uint)((int)windowLongPtr);
                //
                for (int i = 0; i < _vStyles.Length; i++)
                {
                    // получаем стиль окна из списка
                    uint num2 = (uint)Enum.Parse(typeof(WindowStyle), _vStyles[i]);
                    // сравниваем параметр стиля окна и стиля окна приложения
                    bool flag = (num2 & num) == num2; // если ==
                    if (flag)
                    {
                        lsbStyles.Items.Add(_vStyles[i] + " = On");
                    }
                    else
                    {
                        lsbStyles.Items.Add(_vStyles[i] + " = Off");
                    }
                }
            }
            // аналогия с Style
            if (styleEx)
            {
                IntPtr windowLongPtr = GetWindowLongPtr(_hWndFindPtr, WindowLongFlags.GWL_EXSTYLE);
                lsbStylesEx.Items.Clear();
                _vStylesEx = Enum.GetNames(typeof(WindowStyleEx));
                uint num = (uint)((int)windowLongPtr);
                for (int j = 0; j < _vStylesEx.Length; j++)
                {
                    uint num2 = (uint)Enum.Parse(typeof(WindowStyleEx), _vStylesEx[j]);
                    bool flag2 = (num2 & num) == num2;
                    if (flag2)
                    {
                        lsbStylesEx.Items.Add(_vStylesEx[j] + " = On");
                    }
                    else
                    {
                        lsbStylesEx.Items.Add(_vStylesEx[j] + " = Off");
                    }
                }
            }
        }

        // под-функция разрядности системы ( GetWndLongPtr )
        public static IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex)
        {
            bool flag = IntPtr.Size == 0;
            IntPtr result;
            if (flag)
            {
                result = Form1.GetWindowLongPtr64(hWnd, nIndex);
            }
            else
            {
                result = Form1.GetWindowLongPtr32(hWnd, nIndex);
            }

            return result;
        }

        // под-функция разрядности системы ( SetWndLongPtr )
        public static IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {
            bool flag = IntPtr.Size == 0;
            IntPtr result;
            if (flag)
            {
                result = Form1.SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
            }
            else
            {
                result = new IntPtr(Form1.SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
            }

            return result;
        }

        private void bFindWindow_Click(object sender, EventArgs e)
        {
            if (tbEntTitleWnd.Text.Length > 0)
            {
                _hWndFindPtr = Form1.FindWindow(null, tbEntTitleWnd.Text);
                if (_hWndFindPtr != IntPtr.Zero)
                {
                    picResultFind.BackColor = Color.Green;
                    // загружаем стили найденного окна
                    GetStylesWnd(true, true);
                    lsbStyles.Visible = true;
                    lsbStylesEx.Visible = true;
                }
                else
                {
                    picResultFind.BackColor = Color.Red;
                    lsbStyles.Visible = false;
                    lsbStylesEx.Visible = false;
                }
            }
        }

        private void lsbStyles_MouseDoubleClick(object sender, EventArgs e)
        {
            bool flag = lsbStyles.SelectedIndex == -1;
            if (!flag)
            {
                WindowStyle windowStyle =
                    (WindowStyle)Enum.Parse(typeof(WindowStyle), _vStyles[lsbStyles.SelectedIndex]);
                IntPtr windowLongPtr = GetWindowLongPtr(_hWndFindPtr, WindowLongFlags.GWL_STYLE);
                uint num = (uint)((int)windowLongPtr);
                uint num2 = num ^ (uint)windowStyle;
                IntPtr intPtr = SetWindowLongPtr(_hWndFindPtr, WindowLongFlags.GWL_STYLE, (IntPtr)((long)((ulong)num2)));
                GetStylesWnd(true, false);
            }
        }

        private void lsbStylesEx_DoubleClick(object sender, EventArgs e)
        {
            bool flag = lsbStylesEx.SelectedIndex == -1;
            if (!flag)
            {
                WindowStyleEx windowStyleEx =
                    (WindowStyleEx)Enum.Parse(typeof(WindowStyleEx), _vStylesEx[lsbStylesEx.SelectedIndex]);
                IntPtr windowLongPtr = GetWindowLongPtr(_hWndFindPtr, WindowLongFlags.GWL_EXSTYLE);
                uint num = (uint)((int)windowLongPtr);
                uint num2 = num ^ (uint)windowStyleEx;
                IntPtr intPtr = SetWindowLongPtr(_hWndFindPtr, WindowLongFlags.GWL_EXSTYLE, (IntPtr)((long)((ulong)num2)));
                GetStylesWnd(false, true);
            }
        }
    }
}