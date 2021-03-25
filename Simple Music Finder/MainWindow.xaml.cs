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
using Simple_Music_Finder.Classes;
using Simple_Music_Finder.Classes.Providers;

namespace Simple_Music_Finder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Provider.Load(new GetTune());
            var Providers = Provider.GetList();
            foreach(Provider provider in Providers)
            {
                TextBlock ProviderTitle = new TextBlock();
                ProviderTitle.Text = provider.Name;
                ProvidersListBox.Items.Add(ProviderTitle);
            }
            string Version = "V: ";
            foreach(int ver in Provider.Version)
            {
                Version += ver.ToString() + ".";
            }
            MessageBox.Show(Version);
        }
    }
}
