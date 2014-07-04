using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Syntra_SVL.Source;

namespace Syntra_SVL
{
    public partial class MainWindow : Window
    {
        private apiary aServer;
        private Data dData;
        private readonly string[] sListApiary = new string[6] {"All",
            "Registreer een aanvraag", "Registreer een aanvraag met issues", "Wijzig een aanvraag",
            "Registreer een aanvraag 2", "Wijzig aanvragen collection 2"};

        public MainWindow()
        {
            InitializeComponent();
            aServer = new apiary();
            dData = new Data();
        }

        private async void btn_Click(object sender, RoutedEventArgs e)
        {
            if (choices.SelectedIndex == 0)
            {
                Thread run = new Thread(() =>
                {
                    Dispatcher.Invoke(() =>
                    {
                        output.Text = "All:\n";
                    });
                    for (int i = 0; i < sListApiary.Length - 1; i++)
                    {
                        string sData = sListApiary[i + 1] + "\n" + aServer.requestApiary(dData.getData(i)) + "\n\n";
                        Dispatcher.Invoke(() =>
                        {
                            output.Text += sData;
                        });
                    }
                    Dispatcher.Invoke(() =>
                    {
                        output.Text += "End";
                    });
                });
                run.Start();
            }
            else
            {
                output.Text = aServer.requestApiary(dData.getData(choices.SelectedIndex - 1));
            }
        }

        private void choices_Loaded(object sender, RoutedEventArgs e)
        {
            choices.ItemsSource = sListApiary.ToList<string>();
            choices.SelectedIndex = 0;
        }
    }
}