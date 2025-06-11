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

namespace _3._2Laba_2_sem_OOP
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Random random = new Random();
        private int minSize = 10;
        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ніхо й не сумнівся!!");
        }

        
        private void NoButton_MouseEnter (object sender, MouseEventArgs e)
        {
            double newX = random.Next(0, (int) (this.ActualWidth - NoButton.Width - 10));
            double newY = random.Next(30, (int) (this.ActualWidth - NoButton.Width - 10));

            if (NoButton.Width > minSize && NoButton.Height > minSize)
            {
                NoButton.Width -= 2;
                NoButton.Height -=2;
            }

            NoButton.Margin = new Thickness(newX, newY, 0,0);

        }
        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Зверніться за номером: 0 800 60 20 19 ");
        }


    }
}
