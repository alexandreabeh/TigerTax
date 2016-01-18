using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SQLite;
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
            using (var tigerTaxConnection = new SQLiteConnection(ConnectionString))
            {
                tigerTaxConnection.Open();
                // Comment out once this table is set the way it's supposed to be
                string sqlDeleteRecordTable = "DROP TABLE IF EXISTS Records";
                var dropCommand = new SQLiteCommand(sqlDeleteRecordTable, tigerTaxConnection);
                dropCommand.ExecuteNonQuery();
                string sqlCreateRecordTable =
                    "CREATE TABLE IF NOT EXISTS Records (Id INTEGER PRIMARY KEY AUTOINCREMENT , Name VARCHAR NOT NULL , TotalAmount DOUBLE NOT NULL, DateModified TIMESTAMP DEFAULT CURRENT_TIMESTAMP)";
                SQLiteCommand commandCreateRecordTable = new SQLiteCommand(sqlCreateRecordTable, tigerTaxConnection);
                commandCreateRecordTable.ExecuteNonQuery();
            }
            //TigerTaxContext context = new TigerTaxContext();
            //context.Records.OrderBy(c => c.DateUpdated).Load();
            //DataGridOpenRecord.ItemsSource = context.Records.Local;
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int minNameLength = 2;

            newFileName = WindowTigerTax.TextBoxNewRecordName.Text;

            if (null != newFileName && newFileName.Trim().Length >= minNameLength)
            {
                // Create new record and write it to the database, assign active record id and launch add category menu
                // Strip any whitespace
                using (var tigerTaxConnection = new SQLiteConnection(ConnectionString))
                {
                    var results = new List<Record>();
                    tigerTaxConnection.Open();

                    string sql = "INSERT INTO Records (Name, TotalAmount, DateModified) VALUES ('" + newFileName + "', 0, datetime('now'))";
                    SQLiteCommand command = new SQLiteCommand(sql, tigerTaxConnection);
                    command.ExecuteNonQuery();

                    command.ExecuteNonQuery();

                    string sqlselect = "SELECT * FROM Records";
                    SQLiteCommand selectCommand = new SQLiteCommand(sqlselect, tigerTaxConnection);
                    SQLiteDataReader reader = selectCommand.ExecuteReader();
                    // working now!
                    while (reader.Read())
                    {
                        var id = reader["Id"];
                        var name = reader["Name"];
                        var totalAmount = reader["TotalAmount"];
                        var dateModified = reader["DateModified"];
                    }
                }
            }
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
