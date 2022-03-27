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
using System.Windows.Threading;
using Demo334.DataBase;
using Demo334.Pages;


namespace Demo334.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageInfoMaterial.xaml
    /// </summary>
    public partial class PageInfoMaterial : Page
    {
        public PageInfoMaterial()
        {
            InitializeComponent();
            UpdateData();
            //DispatcherTimer timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromSeconds(1);
            //timer.Tick += UpdateData;
            //timer.Start();

        }

        public void UpdateData()
        {
            var AllMaterials = Connect.conn.Material.ToList();
            ListMaterial.ItemsSource = AllMaterials;
            //ListMaterial.ItemsSource = Connect.conn.Material.Where(x => x.Title.StartsWith(TxtSearch.Text) || x.Description.StartsWith(TxtSearch.Text)).ToList();
        }

        private void TxtSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ListMaterial.ItemsSource = Connect.conn.Material.Where(x => x.Title.StartsWith(TxtSearch.Text) || x.Description.StartsWith(TxtSearch.Text)).ToList();
        }
    }
}
