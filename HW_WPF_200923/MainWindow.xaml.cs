using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW_WPF_200923
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly Random random = new Random();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Ask(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxInput.Text.Trim()))
            {
                string[] answers = { "Да", "Нет", "Не могу сказать" };
                int index = random.Next(answers.Length);
                string randomAnswer = answers[index];
                textBoxAnswer.Text = randomAnswer;
            }
            else
            {
                MessageBox.Show("Введите вопрос перед тем как нажыть на эту кнопку!!!");
            }
        }
	}
}
