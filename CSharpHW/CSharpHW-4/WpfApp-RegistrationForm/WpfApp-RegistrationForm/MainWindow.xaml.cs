using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Text.RegularExpressions;
using System.Windows.Controls;


namespace WpfApp_RegistrationForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        public void Check()
        {
            Regex rgxPhoneNumber = new Regex(@"^\d{12}$");
            Regex rgxEmail = new Regex("@");
            Regex rgxName = new Regex("^[A-Za-z]{1,125}$");

            DateTime date = Convert.ToDateTime(TextBoxB.Text);

            if (!(TextBoxA.Text.Length < 2000))
            {
                throw new FormatException("Error in Additional Info");
            }

            if (!(rgxName.IsMatch(TextBoxF.Text)))
            {
                throw new FormatException("Error in First Name");
            }

            if (!(rgxPhoneNumber.IsMatch(TextBoxP.Text)))
            {
                throw new FormatException("Error in Phone Number");
            }

            if (!(rgxEmail.IsMatch(TextBoxE.Text)) && (TextBoxE.Text.Length < 255))
            {
                throw new FormatException("Error in Email");
            }

            if (!(TextBoxG.Text == "male" || TextBoxG.Text == "female"))
            {
                throw new FormatException("Error in Gender");
            }

            if (!(rgxName.IsMatch(TextBoxL.Text)))
            {
                throw new FormatException("Error in Last Name");
            }

            if (!(((0 < date.Day) || (date.Day < 32)) &&
                ((0 < date.Month) || (date.Month < 13)) &&
                ((1900 < date.Year) || (date.Year < DateTime.Today.Year)) &&
                rgxDate.IsMatch(TextBoxB.Text)))
            {
                throw new FormatException("Error in Date");
            }



        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Check();
                LabelInfo.Content = "Everything is ok";
            }
            catch (Exception exception)
            {
                LabelInfo.Content = exception.Message;
            }
        }
    }
}
