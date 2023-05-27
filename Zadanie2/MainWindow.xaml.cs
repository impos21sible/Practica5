using System;
using System.Linq;
using System.Windows;

namespace Zadanie2
{
    public partial class MainWindow : Window
    {
        private int count;
        private int sum;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TbNumber.Text, out int number))
            {
                ListBoxData.Items.Add(number);
                if (number >= 100 && number <= 999)
                {
                    count++;
                    sum += number;
                }
                TbNumber.Clear();
            }
            else
            {
                MessageBox.Show("Введите корректное число!");
            }
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            if (count > 0)
            {
                double average = (double)sum / count;
                TextBlockAnswer.Text = $"Ответ:\n{average}";
            }
            else
            {
                TextBlockAnswer.Text = "NO";
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
