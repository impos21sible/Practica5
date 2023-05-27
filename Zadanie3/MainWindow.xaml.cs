using System;
using System.Windows;

namespace Zadanie3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            ListBoxResults.Items.Clear();

            if (double.TryParse(TbPricePerKg.Text, out double pricePerKg))
            {
                for (double weight = 1.2; weight <= 2.0; weight += 0.2)
                {
                    double totalPrice = pricePerKg * weight;
                    ListBoxResults.Items.Add($"Вес: {weight:F1} кг, Стоимость: {totalPrice:F2}");
                }
            }
            else
            {
                MessageBox.Show("Введите корректную цену за 1 кг конфет.");
            }
        }
    }
}
