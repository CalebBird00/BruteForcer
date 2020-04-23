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
using System.Diagnostics;
using System.Threading;


namespace BruteForcer
{   
     class Console
    {
        
        public static void UserConsole(string text)
        {
          //  FlowDocument Console = new FlowDocument();

           // Console.Blocks.Add(new Paragraph(new Run(text)));

            ((MainWindow)Application.Current.MainWindow).ConsoleBox.AppendText(Environment.NewLine + text);
        }
    }
}
