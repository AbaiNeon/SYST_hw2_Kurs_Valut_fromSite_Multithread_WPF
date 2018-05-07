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
using System.Net;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace SYST_hw2_kurs_valyt_async
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnKursValut_Click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                string url = @"http://data.egov.kz/api/v2/valutalar_bagamdary4/v312?pretty";
                string json;

                using (WebClient wc = new WebClient())
                {
                    wc.Encoding = Encoding.UTF8;
                    json = wc.DownloadString(url);
                }

                List<Currency> list1 = JsonConvert.DeserializeObject<List<Currency>>(json);

                //mainDataGrid.ItemsSource = list1;

                Thread.Sleep(5000);

                mainDataGrid.Dispatcher.Invoke(new Action(() =>
                {
                    mainDataGrid.ItemsSource = list1;
                }));
            });
            thread.Start();
        }
    }
}
