Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Xml

Namespace TestMasterSlave

  Partial Public Class MainWindow
      Inherits Window

    Public myDataSet As DataSet = Nothing

    Public Sub New()
      ' Build the DataSet as it comes from SQL-Server
      myDataSet = New DataSet()
      myDataSet.ReadXmlSchema("../../ExampleDataSetSchema.xsd")
      Dim xDoc As New XmlDocument()
      xDoc.Load("../../ExampleDataSet.xml")
      myDataSet.ReadXml(New XmlNodeReader(xDoc), XmlReadMode.Fragment)

      InitializeComponent()

      DataContext = myDataSet
    End Sub
  End Class
End Namespace
