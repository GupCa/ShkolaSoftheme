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
using System.Text.RegularExpressions;


namespace WpfApp_Zodiac
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

        private  DateTime GetDateOfBirth()
        {
            var birthDay = TextBox.Text;

            string pattern = "[0-9]{2}/[0-9]{2}/[0-9]{4}";
            Regex rx = new Regex(pattern);
            if (!rx.IsMatch(birthDay))
            {
                GetDateOfBirth();
            }

            var date = Convert.ToDateTime(birthDay);
            return date;
        }

        private  void Zodiac(DateTime date)
        {
            switch (date.Month)
                {
                case 1:
                    if (date.Day <= 20)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Capricorn";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/capricorn.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Aquarius";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/aquarius.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                        }
                break;

                case 2:
                    if (date.Day <= 19)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Aquarius";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/aquarius.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Pisces";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/pisces.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    break;
                    
                case 3:
                    if (date.Day <= 20)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Pisces";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/pisces.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Aries";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/aries.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    break;
           
                case 4:
                    if (date.Day <= 20)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Aries";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/aries.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Taurus";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/taurus.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    break;

                case 5:
                    if (date.Day <= 21)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Taurus";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/taurus.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Gemini";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/gemini.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    break;

                case 6:
                    if (date.Day <= 22)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Gemini";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/gemini.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Cancer";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/cancer.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    break;           

                case 7:
                    if (date.Day <= 22)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Cancer";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/cancer.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Leo";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/leo.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    break;
                   
                case 8:
                    if (date.Day <= 23)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Leo";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/leo.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Virgo";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/virgo.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    break;
           
                case 9:
                    if (date.Day <= 23)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Virgo";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/virgo.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Libra";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/libra.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    break;

                case 10:
                    if (date.Day <= 23)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Libra";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/libra.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Scorpio";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/scorpio.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    break;

                case 11:
                    if (date.Day <= 22)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Scorpio";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/scorpio.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Sagittarius";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/sagittarius.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    break;
                   
                case 12:
                    if (date.Day <= 21)
                    {
                        Label_zodiac.Content = "Your zodiac sign is Sagittarius";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/sagittarius.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    else
                    {
                        Label_zodiac.Content = "Your zodiac sign is Capricorn";
                        var uriSource = new Uri(@"/WpfApp-Zodiac;component/images/capricorn.jpg", UriKind.Relative);
                        Image_zodiac.Source = new BitmapImage(uriSource);
                    }
                    break; 

                default:
                    Label_zodiac.Content = "Your zodiac sign was not found! Please try again!";
                    break;
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var date = GetDateOfBirth();
            var years = (int)Math.Floor((DateTime.Now - date).TotalDays / 365);

            Label_age.Content = $"Your age is: {years}";
            Zodiac(date);
        }

    }
}

