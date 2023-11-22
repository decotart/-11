using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Практическая_работа__11
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

        private void Window_Initialized(object sender, EventArgs e)
        {
            string value = tbString.Text;
            MatchCollection result;
            Regex regex;

            regex = new("a(b{0,1})a");
            result = regex.Matches(value);

            tbResult1.Text = GetResult(result);
            tbRegex1.Text = regex.ToString();

            regex = new("a[3-7]a");
            result = regex.Matches(value);

            tbResult2.Text = GetResult(result);
            tbRegex2.Text = regex.ToString();
        }

        private string GetResult(MatchCollection collection)
        {
            string result = "";

            if (collection.Count != 0)
            {
                for (int i = 0; i < collection.Count; i++)
                {
                    result = result + " " + collection[i].Value;
                }
            }
            else result = "Совпадений нет";

            return result;
        }
    }
}
