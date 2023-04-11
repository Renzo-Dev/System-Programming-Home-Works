using System;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace WpfApp1
{
    // Создайте оконное приложение, которое генерирует набор простых чисел в
    // диапазоне, указанном пользователем.Если не указана нижняя граница
    // предел, поток стартует с 2. Если верхний предел не указан,
    // генерирование происходит до завершения приложения.
    // Используйте механизм потоков.Числа должны отображаться в
    // оконном интерфейсе.
    //
    // Задание 2:
    //
    // Добавьте к первой задаче поток, генерирующий набор чисел
    // Фибоначчи. Числа должны отображаться в оконном интерфейсе.
    //
    // Задача 3:
    //
    // Добавьте во вторую задачу кнопки для полной остановки каждого
    // из потоков.Одна кнопка для одного потока.Если пользователь
    // нажал кнопку остановки, поток полностью прекращает свою работу.
    //
    // Задача 4:
    //
    // Добавьте в третью задачу кнопки для приостановки и
    // возобновления каждого из потоков. Например, пользователь может
    // приостановить генерацию чисел Фибоначчи нажав на кнопку.
    // Продолжение генерации возможно после нажатия на другую
    // кнопку.
    //
    // Задача 5:
    //
    // Добавьте в четвертую задачу возможность полного рестарта потоков с новыми границами
    // потоков с новыми границами.
    //
    // Приложение:
    //
    // поток генерации простых чисел
    // поток генерации чисел фибоначчи
    //
    // функция инициализации потоков
    //
    // кнопка генерации

    public partial class MainWindow
    {
        private Thread _threadPrimeGeneration; // поток генерации простых чисел
        private Thread _threadFebonacciGeneration; // поток генерации чисел Фибоначчи

        public MainWindow()
        {
            InitializeComponent();

            _threadPrimeGeneration = new Thread(GeneratePrimeValues)
            {
                IsBackground = true
            };
            _threadFebonacciGeneration = new Thread(GeneratorFebonacci)
            {
                IsBackground = true
            };
        }

        private void DragMove(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void CloseProgram(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // нажатие кнопки генерации простых чисел
        [Obsolete("Obsolete")]
        private void BPrimeValues_Click(object sender, RoutedEventArgs e)
        {
            if (_threadPrimeGeneration.ThreadState == (ThreadState.Unstarted | ThreadState.Background))
            {
                _threadPrimeGeneration.Start();
            }
            else
            {
                // устраняем причины поломки Abort ( вроде ток Suspend )
                if (_threadPrimeGeneration.ThreadState == (ThreadState.Suspended | ThreadState.Background))
                {
                    _threadPrimeGeneration.Resume();
                }

                _threadPrimeGeneration.Abort();

                _threadPrimeGeneration = new Thread(GeneratePrimeValues)
                {
                    IsBackground = true
                };
                _threadPrimeGeneration.Start();
            }
        }

        // функция добавления нового элемента в ListBox , через асинх.делегат
        private void AddValueInListBox(int minValue, System.Windows.Controls.ListBox listBox)
        {
            Dispatcher.BeginInvoke((MethodInvoker)delegate { listBox.Items.Add(minValue); });
        }

        // генерируем простые числа в диапазоне
        private void GeneratePrimeValues()
        {
            LbPrimeValues.Dispatcher.BeginInvoke((MethodInvoker)delegate { LbPrimeValues.Items.Clear(); });
            bool isPrime = false;
            int minValue = 2;
            int maxValue = int.MaxValue;

            if (GetLengthTbMin() > 0)
            {
                minValue = GetMinValue();
            }

            if (GetLengthTbMax() > 0)
            {
                maxValue = GetMaxValue();
            }

            for (; minValue <= maxValue; ++minValue)
            {
                for (int i = 2; i <= minValue / 2; ++i)
                {
                    if (minValue % i != 0)
                    {
                        isPrime = true;
                    }
                    else
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime == true)
                {
                    AddValueInListBox(minValue, LbPrimeValues);
                }
            }
        }

        // генератор чисел Фибоначчи
        private void GeneratorFebonacci()
        {
            Dispatcher.BeginInvoke((MethodInvoker)delegate { LbFebonacci.Items.Clear(); });

            int valueF = 1;
            int maxValue = 1000000000;
            if (GetLengthTbMax() > 0)
            {
                maxValue = GetMaxValue();
            }

            for (int i = 1; i <= maxValue; i += valueF)
            {
                AddValueInListBox(valueF, LbFebonacci);
                valueF = i - valueF;
                Thread.Sleep(50);
            }
        }

        // получения длины строки MaxTextBox
        private int GetLengthTbMax()
        {
            int GetLength() => TbMaxValue.Text.Length;
            return TbMaxValue.Dispatcher.Invoke(GetLength);
        }

        // получения длины строки MinTextBox
        private int GetLengthTbMin()
        {
            int GetLength() => TbMinValue.Text.Length;
            return TbMinValue.Dispatcher.Invoke(GetLength);
        }

        // получение значения MinTextBox
        private int GetMinValue()
        {
            int GetValue() => Convert.ToInt32(TbMinValue.Text);
            return Convert.ToInt32(TbMinValue.Dispatcher.Invoke(GetValue));
        }

        // получение значения MaxTextBox
        private int GetMaxValue()
        {
            int GetValue() => Convert.ToInt32(TbMaxValue.Text);
            return Convert.ToInt32(TbMaxValue.Dispatcher.Invoke(GetValue));
        }

        // кнопка приостановки потока
        [Obsolete("Obsolete")]
        private void BPrimeThreadPause_Click(object sender, RoutedEventArgs e)
        {
            if (_threadPrimeGeneration.IsAlive)
            {
                _threadPrimeGeneration.Suspend();
            }
        }

        // кнопка возобновление(если приостановлен) потока
        [Obsolete("Obsolete")]
        private void BPrimeThreadResume_Click(object sender, RoutedEventArgs e)
        {
            if (_threadPrimeGeneration.ThreadState == (ThreadState.Suspended | ThreadState.Background))
                _threadPrimeGeneration.Resume();
        }

        // кнопка остановки потока
        [Obsolete("Obsolete")]
        private void BPrimeThreadStopped_Click(object sender, RoutedEventArgs e)
        {
            if (_threadPrimeGeneration.ThreadState == (ThreadState.Suspended | ThreadState.Background))
            {
                _threadPrimeGeneration.Resume();
                _threadPrimeGeneration.Abort();
            }

            if (_threadPrimeGeneration.ThreadState == ThreadState.Background)
            {
                _threadPrimeGeneration.Abort();
            }
        }

        [Obsolete("Obsolete")]
        private void BFebonacciValues_Click(object sender, RoutedEventArgs e)
        {
            if (_threadFebonacciGeneration.ThreadState == (ThreadState.Unstarted | ThreadState.Background))
            {
                _threadFebonacciGeneration.Start();
            }
            else
            {
                // устраняем причины поломки Abort ( вроде ток Suspend )
                if (_threadFebonacciGeneration.ThreadState == (ThreadState.Suspended | ThreadState.Background))
                {
                    _threadFebonacciGeneration.Resume();
                }

                _threadFebonacciGeneration.Abort();

                _threadFebonacciGeneration = new Thread(GeneratorFebonacci)
                {
                    IsBackground = true
                };
                _threadFebonacciGeneration.Start();
            }
        }

        [Obsolete("Obsolete")]
        private void BFebonacciThreadPause_Click(object sender, RoutedEventArgs e)
        {
            if (_threadFebonacciGeneration.IsAlive)
            {
                _threadFebonacciGeneration.Suspend();
            }
        }

        [Obsolete("Obsolete")]
        private void BFebonacciThreadResume_Click(object sender, RoutedEventArgs e)
        {
            if (_threadFebonacciGeneration.ThreadState == (ThreadState.Suspended | ThreadState.Background))
                _threadFebonacciGeneration.Resume();
        }

        [Obsolete("Obsolete")]
        private void BFebonacciThreadStopped_Click(object sender, RoutedEventArgs e)
        {
            if (_threadFebonacciGeneration.ThreadState == (ThreadState.Suspended | ThreadState.Background))
            {
                _threadFebonacciGeneration.Resume();
                _threadFebonacciGeneration.Abort();
            }

            if (_threadFebonacciGeneration.ThreadState == ThreadState.Background)
            {
                _threadFebonacciGeneration.Abort();
            }
        }
    }
}