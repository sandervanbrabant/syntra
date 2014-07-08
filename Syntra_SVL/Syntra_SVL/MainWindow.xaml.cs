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
        private Thread tRun;
        private readonly string[] sListApiary = new string[34] {"All",
            "Registreer een aanvraag", "Registreer een aanvraag met issues", "Wijzig een aanvraag",
            "Registreer een aanvraag 2", "Wijzig aanvragen collection 2", "Registreer een persoon",
            "Registreer een persoon met issues", "Wijzig een persoon", "Opvragen van een persoon",
            "Verwijder een persoon", "Zoek een persoon op externe referentie", "Registreer een bedrijf",
            "Registreer een bedrijf met issues", "Wijzig een bedrijf", "Verwijder een bedijf",
            "Registreer een contactgegeven", "Wijzig een contactgegeven", "Verwijder een contactgegeven",
            "Registreer een inschrijving", "Wijzig een inschrijving", "Verwijder een inschrijving",
            "Registreer een lesmoment", "Wijzig een lesmoment", "Registreer een prestatie",
            "Wijzig een prestatie", "Verwijder een prestatie", "Registreer een jurylid",
            "Wijzig een jurylid", "Verwijder een jurylid", "Registreer een aanwezigheid",
            "Wijzig een aanwezigheid", "Verwijder een aanwezigheid", "Zoek een moduleversie"};

        public MainWindow()
        {
            InitializeComponent();
            aServer = new apiary();
            dData = new Data();
            fake.IsChecked = true;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (choices.SelectedIndex == 0)
            {
                tRun = new Thread(() =>
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
                tRun.Start();
            }
            else
            {
                tRun = new Thread(() =>
                {
                    string sData = sListApiary[choices.SelectedIndex] + "\n\n" +
                        aServer.requestApiary(dData.getData(choices.SelectedIndex - 1));
                    Dispatcher.Invoke(() =>
                    {
                        output.Text = sData;
                    });
                });
                tRun.Start();
            }
        }

        private void choices_Loaded(object sender, RoutedEventArgs e)
        {
            choices.ItemsSource = sListApiary.ToList<string>();
            choices.SelectedIndex = 0;
        }

        private void fake_Checked(object sender, RoutedEventArgs e)
        {
            aServer.setChoice(true);
        }

        private void fake_Unchecked(object sender, RoutedEventArgs e)
        {
            aServer.setChoice(false);
        }

        private override void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            tRun.Abort();
        }
    }
}