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

namespace Question1
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

        private void IntegersBtn_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            Int0TextBox.Text = rand.Next(0, 100).ToString();
            Int1TextBox.Text = rand.Next(0, 100).ToString();
            Int2TextBox.Text = rand.Next(0, 100).ToString();
            Int3TextBox.Text = rand.Next(0, 100).ToString();
            Int4TextBox.Text = rand.Next(0, 100).ToString();
        }

        private void DoublesBtn_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            Double0TextBox.Text = (rand.Next(0, 99) + rand.NextDouble()).ToString("n1");
            Double1TextBox.Text = (rand.Next(0, 99) + rand.NextDouble()).ToString("n1");
            Double2TextBox.Text = (rand.Next(0, 99) + rand.NextDouble()).ToString("n1");
            Double3TextBox.Text = (rand.Next(0, 99) + rand.NextDouble()).ToString("n1");
            Double4TextBox.Text = (rand.Next(0, 99) + rand.NextDouble()).ToString("n1");
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            string strKey = SearchTextBox.Text;
            int location;
            
            try
            {
                if (strKey.Contains("."))
                {
                    double key = double.Parse(strKey);

                    try
                    {
                        double[] doubles =
                        {
                            double.Parse(Double0TextBox.Text),
                            double.Parse(Double1TextBox.Text),
                            double.Parse(Double2TextBox.Text),
                            double.Parse(Double3TextBox.Text),
                            double.Parse(Double4TextBox.Text)
                        };

                        location = Search(key, doubles);

                        if (location != -1)
                        {
                            MessageTextBox.Text = "The number " + key + " is at doubles array position #" + location;
                            //doubles.Select(d => d == key);
                        }
                        else
                        {
                            MessageTextBox.Text = "The number " + key + " was not found.";
                        }
                    }
                    catch (Exception)
                    {
                        MessageTextBox.Text = "The number " + key + " was not found.";
                    }
                }
                else
                {
                    int key = int.Parse(strKey);

                    try
                    {
                        int[] integers =
                        {
                            int.Parse(Int0TextBox.Text),
                            int.Parse(Int1TextBox.Text),
                            int.Parse(Int2TextBox.Text),
                            int.Parse(Int3TextBox.Text),
                            int.Parse(Int4TextBox.Text)
                        };

                        location = Search(key, integers);

                        if (location != -1)
                        {
                            MessageTextBox.Text = "The number " + key + " is at integers array position #" + location;
                            //doubles.Select(d => d == key);
                        }
                        else
                        {
                            MessageTextBox.Text = "The number " + key + " was not found.";
                        }
                    }
                    catch (Exception)
                    {
                        MessageTextBox.Text = "The number " + key + " was not found.";
                    }
                }
            }
            catch (FormatException)
            {
                MessageTextBox.Text = "Click a button to generate numbers and type a number to search.";
            }

        }

        private int Search<T>(T key, T[] array) where T : IComparable<T>
        {
            int result = -1;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                int r = key.CompareTo(array[i]);
                if (r == 0)
                {
                    result = i;
                }
            }

            return result;
        }
    }
}
