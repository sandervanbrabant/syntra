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
using Syntra_SVL.Source;

namespace Syntra_SVL
{
    public partial class MainWindow : Window
    {
        private apiary aServer;
        private Data dData;
        private readonly string[] sListApiary = new string[5] {
            "Registreer een aanvraag", "Registreer een aanvraag met issues", "Wijzig een aanvraag",
            "Registreer een aanvraag 2", "Wijzig aanvragen collection 2"};

        public MainWindow()
        {
            InitializeComponent();
            aServer = new apiary();
            dData = new Data();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            output.Text = aServer.requestApiary(dData.getData(choices.SelectedIndex));
        }

        private void choices_Loaded(object sender, RoutedEventArgs e)
        {
            choices.ItemsSource = sListApiary.ToList<string>();
            choices.SelectedIndex = 0;
        }
    }
}