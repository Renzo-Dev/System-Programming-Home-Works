using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Form active;

        public const int WM_DESTROY = 0x0002;
        public const int WM_CLOSE = 0x0010;
        public const int WM_SETTEXT = 0x000C;

        public Form1()
        {
            InitializeComponent();
        }

        #region Task 1

        private void PanelForm(Form form)
        {
            if (active != null)
            {
                active.Close();
            }

            active = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
        }

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto, EntryPoint = "MessageBox")]
        public static extern bool MessageBox(IntPtr hWnd, string text, string caption, uint type);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, string wParam, string lParam);

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "MessageBeep")]
        public static extern bool MessageBeep(uint uType);

        [DllImport("Kernel32.dll", SetLastError = true, EntryPoint = "Beep")]
        public static extern bool Beep(uint dwFreq, uint dwDuration);

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLongA")]
        public static extern long SetWindowLong(IntPtr hWnd, int hIndex , long dwNewLong);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
        public static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong32(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        public static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        private void BTask1_Click(object sender, EventArgs e)
        {
            // Разработайте приложение, которое использует унаследованный код.
            // необходимо воспользоваться функцией MessageBox из Windows API.
            // Отобразите с помощью MessageBox информацию о вас.
            // Данные должны быть показаны в нескольких
            // должны быть показаны в нескольких MessageBox.

            MessageBox(IntPtr.Zero, "Кошевой Дан Николаевич\nг.Николаев Украина\nСтудент Академии Шаг", "Info about me",
                0);
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BTask2_Click(object sender, EventArgs e)
        {
            PanelForm(new Task2());
        }

        private void BTask3_Click(object sender, EventArgs e)
        {
            PanelForm(new Task3());
        }

        private void BTask4_Click(object sender, EventArgs e)
        {
           PanelForm(new Task4());
        }
    }
}