using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
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
using FontAwesome.WPF;

namespace TigerTax
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int activeRecordId { get; set; }
        private String newFileName = null;

        private String ConnectionString =
            ConfigurationManager.ConnectionStrings["TigerTaxConnection"].ConnectionString;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new TigerTaxContext())
            {
                WindowTigerTax.DataGridRecords.ItemsSource = db.Records.Local;
            }

            WindowTigerTax.Icon = ImageAwesome.CreateImageSource(FontAwesomeIcon.Paw, Brushes.Sienna);
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int minNameLength = 2;

            newFileName = WindowTigerTax.TextBoxNewRecordName.Text;

            if (null != newFileName && newFileName.Trim().Length >= minNameLength)
            {
                // Create new record and write it to the database, assign active record id and launch add category menu
                // Strip any whitespace
                using ( var db = new TigerTaxContext() )
                {
                    // Create and save a new record
                    var record = new Record()
                    {
                        DateModified = DateTime.UtcNow,
                        Name = newFileName,
                        TotalAmount = 0
                    };

                    try
                    {
                        db.Records.Add(record);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        throw;
                    }                 
                }
            }
        }

        private void DataGridRecords_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO: implement opening of the record
        }

        private void btnRenameRecord_Click(object sender, RoutedEventArgs e)
        {
            // validate valid file name
            // update and save changes
            // update the datagrid
        }

        private void btnDeleteRecord_Click(object sender, RoutedEventArgs e)
        {
            // confirm deletion
            // delete and save changes
            // find a good toast integration for confirmation of deletion
        }
    }
}
