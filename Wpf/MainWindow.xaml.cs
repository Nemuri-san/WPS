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
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.IO;
using System.Data.Sql;


namespace Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        class SaveXml
        {
            public static void savedata(object obj, string filename)
            {
                XmlSerializer sr = new XmlSerializer(obj.GetType());
                TextWriter writer = new StreamWriter(filename);
                sr.Serialize(writer, obj);
                writer.Close();

            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                information info = new information();
                info.Pos = Position.Text;
                info.Sal = Salary.Text;
                SaveXml.savedata(info, "Employment.xml");
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.Position.Text = "";
            this.Salary.Text = "";
            this.Name.Text = "";
            this.Age.Text = "";
            this.NRIC.Text = "";
            this.Address.Text = "";
            this.Email.Text = "";
            this.Instution1.Text = "";
            this.Start1.Text = "";
            this.End1.Text = "";
            this.Qualification1.Text = "";
            this.Instution2.Text = "";
            this.Start2.Text = "";
            this.End2.Text = "";
            this.Qualification2.Text = "";
            this.Instution3.Text = "";
            this.Start3.Text = "";
            this.End3.Text = "";
            this.Qualification3.Text = "";
            this.Instution3.Text = "";
            this.Start4.Text = "";
            this.End4.Text = "";
            this.Qualification4.Text = "";
            this.Employer1.Text = "";
            this.Address1.Text = "";
            this.Telephone1.Text = "";
            this.SupName1.Text = "";
            this.Duration1.Text = "";
            this.Position1.Text = "";
            this.Employer2.Text = "";
            this.Address2.Text = "";
            this.Telephone2.Text = "";
            this.SupName2.Text = "";
            this.Duration2.Text = "";
            this.Position2.Text = "";
            this.ReferenceYes1.IsChecked = false;
            this.ReferenceNo1.IsChecked = false;
            this.ReferenceYes2.IsChecked = false;
            this.ReferenceNo2.IsChecked = false;
            this.Name3.Text = "";
            this.Position3.Text = "";
            this.Company3.Text = "";
            this.Contact3.Text = "";
            this.Name4.Text = "";
            this.Position4.Text = "";
            this.Company4.Text = "";
            this.Contact4.Text = "";
        }
    }
}
