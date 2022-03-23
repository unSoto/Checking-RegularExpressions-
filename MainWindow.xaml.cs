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

namespace Skrauch_9_0101
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tel_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex reg2 = new Regex(@"^(8|\+7)[0-9]{10}$"); //Телефон
            Match match2 = reg2.Match(tel.Text);

            if (match2.Success) { telcheck.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0)); }

            if (!match2.Success) { telcheck.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0)); }
        }
        
        private void seria_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex reg3 = new Regex(@"^[0-9]{4}(\s|-)[0-9]{6}$"); //Серия
            Match match3 = reg3.Match(seria.Text);

            if (match3.Success) { seriacheck.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0)); }

            if (!match3.Success) { seriacheck.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0)); }
            
        }
       
        private void snils_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            Regex reg = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{3}-[0-9]{2}$"); //СНИЛС
            Match match = reg.Match(snils.Text);

            if (match.Success) { snilscheck.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0)); }

            if (!match.Success) { snilscheck.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0)); }
        }
    }
}
