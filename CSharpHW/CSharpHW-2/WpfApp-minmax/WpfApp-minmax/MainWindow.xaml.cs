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

namespace WpfApp_minmax
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextBlock_main.Text = "type\t  MIN | MAX | DEFAULT ";
            TextBlock_bool.Text = $"bool\t {bool.FalseString} | {bool.TrueString} | {default(bool)}";
            TextBlock_byte.Text = $"byte\t{byte.MinValue} | {byte.MaxValue} | {default(byte)}";
            TextBlock_sbyte.Text = $"sbyte\t{sbyte.MinValue} | {sbyte.MaxValue} | {default(sbyte)} ";
            TextBlock_short.Text = $"short\t{short.MinValue} | {short.MaxValue} | {default(short)} ";
            TextBlock_ushort.Text = $"ushort\t{ushort.MinValue} | {ushort.MaxValue} | {default(ushort)} ";
            TextBlock_int.Text = $"int\t{int.MinValue} | {int.MaxValue} | {default(int)} ";
            TextBlock_uint.Text = $"uint\t{ uint.MinValue} | {uint.MaxValue} | {default(uint)} ";
            TextBlock_long.Text = $"long\t{long.MinValue} | {long.MaxValue} | {default(long)} ";
            TextBlock_ulong.Text = $"ulong\t{ulong.MinValue} | {ulong.MaxValue} | {default(ulong)} ";
            TextBlock_float.Text = $"float\t{float.MinValue} | {float.MaxValue} | {default(float)} ";
            TextBlock_double.Text = $"double\t{double.MinValue} | { double.MaxValue} | {default(double)} ";
            TextBlock_decimal.Text = $"decimal\t{decimal.MinValue} | {decimal.MaxValue} | {default(decimal)} ";

        }
    }
}
