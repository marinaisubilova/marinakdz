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
using System.IO;

namespace Cosmetics
{
    /// <summary>
    /// Interaction logic for Result.xaml
    /// </summary>
    public partial class Result : Page
    {
        List<Products> result = new List<Products>();
        string filename;
        public Result(string parametr)
        {
            InitializeComponent();
            switch(parametr)
            {
                case "Eyes and lips":
                    {
                        filename = "example.txt";
                        StreamReader sr = new StreamReader("example.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));
                            
                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }

                    } break;
                case "Cleansing":
                    {
                        
                        StreamReader sr = new StreamReader("skincareclean.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }

                    } break;
                case "Moisturising":
                    {
                        
                        StreamReader sr = new StreamReader("skincaremoist.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }
                    } break;
                case "Makeup remove":
                    {
                        
                        StreamReader sr = new StreamReader("skincareremove.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }
                    } break;
                case "Face":
                    {
                        
                        StreamReader sr = new StreamReader("macface.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }
                    } break;
                case "Eyes":
                    {
                        
                        StreamReader sr = new StreamReader("maceyes.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }
                    } break;
                case "Lips":
                    {
                        
                        StreamReader sr = new StreamReader("maclips.txt");
                        while (!sr.EndOfStream)
                        {
                            string[] searchresult = sr.ReadLine().Split('*');
                            result.Add(new Products(searchresult[0], searchresult[1], int.Parse(searchresult[2])));

                        }
                        foreach (Products product in result)
                        {
                            ResultTextBox.AppendText(product.productsshow());
                            ResultTextBox.AppendText("\n");
                        }
                    } break;

            }
        }


        private void ResultArrowButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SearchingPage());
        }

        private void ResultSearchButton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBox.Clear();
            foreach (Products product in result)
            {
                if (product.Name.Contains(SearchTextBox.Text))
                {
                    ResultTextBox.AppendText(product.productsshow());
                    ResultTextBox.AppendText("\n");
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e) //delete
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e) //edit
        {
            
        }
    }
}
