using System;
using System.Windows;


namespace WpfApp_PlayWithNumber
{
    public partial class MainWindow : Window
    {
        private int _number;
        private int _attempts;

        public MainWindow()
        {
            InitializeComponent();

            Random rnd = new Random();
            _number = rnd.Next(1, 11);
            _attempts = 0;
        }

        private int Validate()
        {
            int intNumber =0;
            
            intNumber = Convert.ToInt32(TextBox.Text);
            if ((intNumber < 1) || (intNumber > 10))
                throw new Exception("Number has to be betwen 1 and 10");
            
            return intNumber;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int intNumber = 0;
            try
            {
                intNumber = Validate();
            }

            catch (Exception exception)
            {
                Label_info.Content = $"{exception.Message}";
                return;
            }


            _attempts++;

            if (intNumber == _number)
            {
                Label_info.Content = "Congratulation! You won";
                Random rnd = new Random();
                _number = rnd.Next(1, 11);
                _attempts = 0;
            }

            else
            {
                Label_info.Content = $"Wrong, {3 - _attempts} attempts left";

                if (_attempts == 3)
                {
                    Label_info.Content = $"You lose, the number was {_number}";
                    Random rnd = new Random();
                    _number = rnd.Next(1, 11);
                    _attempts = 0;
                }
    
            }        
        }
    }
}
