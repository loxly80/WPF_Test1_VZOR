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

namespace Test_1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      ComboBoxObjekt.SelectedIndex = 0;
    }

    private void ComboBoxObjekt_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      if (ComboBoxObjekt.SelectedIndex == 0) //trojúhelník
      {
        LabelC.Visibility = Visibility.Visible;
        TextBoxC.Visibility = Visibility.Visible;
      }
      else
      {
        LabelC.Visibility = Visibility.Collapsed;
        TextBoxC.Visibility = Visibility.Collapsed;
      }
    }

    private void Button_MouseDown(object sender, MouseButtonEventArgs e)
    {
   

    }

    private void Button_MouseDown(object sender, RoutedEventArgs e)
    {
      double a, b, c;
      double s;
      double obsah;
      try
      {
        if (ComboBoxObjekt.SelectedIndex == 0) //trojúhelník
        {
          a = double.Parse(TextBoxA.Text);
          b = double.Parse(TextBoxB.Text);
          c = double.Parse(TextBoxC.Text);
          s = (a + b + c) / 2;
          obsah = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
          LabelOdpoved.Content = $"Obsah trojúhelníku je {obsah}";
        }
        else
        {
          a = double.Parse(TextBoxA.Text);
          b = double.Parse(TextBoxB.Text);
          obsah = a * b;
          LabelOdpoved.Content = $"Obsah obdélníku je {obsah}";
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Chyba VSTUPNÍCH HODNOT - {ex.Message}");
      }
    }
  }
}
