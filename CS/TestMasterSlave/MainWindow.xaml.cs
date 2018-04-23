using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml;

namespace TestMasterSlave
{

  public partial class MainWindow : Window
  {
    public DataSet myDataSet = null;

    public MainWindow()
    {
      // Build the DataSet as it comes from SQL-Server
      myDataSet = new DataSet();
      myDataSet.ReadXmlSchema("../../ExampleDataSetSchema.xsd");
      XmlDocument xDoc = new XmlDocument();
      xDoc.Load("../../ExampleDataSet.xml");
      myDataSet.ReadXml(new XmlNodeReader(xDoc), XmlReadMode.Fragment);
      
      InitializeComponent();

      DataContext = myDataSet; 
    }
  }
}
