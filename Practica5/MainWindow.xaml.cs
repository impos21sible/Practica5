using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Practica5
{
    public partial class MainWindow : Window
    {
        private List<int> participants = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TbNumber.Text, out int number))
            {
                participants.Add(number);
                ListBoxData.Items.Add(number);
                TbNumber.Clear();
            }
            else
            {
                MessageBox.Show("Введите целое число.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            int maxCorrectAnswers = 0;
            int num = 0;

            foreach (int answer in participants)
            {
                if (answer > maxCorrectAnswers)
                {
                    maxCorrectAnswers = answer;
                }

                if (answer == 0)
                {
                    num = 1;
                }
            }

            TextBlockAnswer.Text = $"Ответ: {maxCorrectAnswers}";

            if (num > 0)
            {
                TextBlockAnswer.Text += " YES";
            }
            else
            {
                TextBlockAnswer.Text += " NO";
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
  