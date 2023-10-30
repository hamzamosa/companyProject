using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Scheduling;

namespace VertexFXClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RadRibbonWindow
    {
        static MainWindow()
        {
            RadRibbonWindow.IsWindowsThemeEnabled = false;
        }
        public bool IsDark = true;
        public MainWindow()
        {
            
            InitializeComponent();


        SwitchLanguage("en");
        }

        private void Arab_Lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("ar");
            ribbon.FlowDirection = FlowDirection.RightToLeft;
            main_layout.FlowDirection = FlowDirection.RightToLeft;
        }

        private void English_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("en");
            ribbon.FlowDirection = FlowDirection.LeftToRight;
            main_layout.FlowDirection = FlowDirection.LeftToRight;
        }

        private void Hindi_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("hindi");
        }

        private void hebrew_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("hebrew");

        }

        private void french_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("french");
        }

        private void urdu_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("urdu");

        }

        private void russian_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("russian");

        }

        private void japanees_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("japanees");
        }

        private void portugal_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("portugal");

        }

        private void china_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("china");
        }

        private void spanch_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("span");

        }

        private void SwitchLanguage(string lang) 
        {

            ResourceDictionary resource = new ResourceDictionary();

            switch (lang) 
            {
                case "en": resource.Source = new Uri("..\\languages/ResourceDictionares.en.xaml", UriKind.Relative);
                    break;
                case "ar":
                    resource.Source = new Uri("..\\languages/Res_Ar.xaml", UriKind.Relative);
                    break;

                case "hindi":
                    resource.Source = new Uri("..\\languages/Resource_Hindi .xaml", UriKind.Relative);
                    break;

                case "span":
                    resource.Source = new Uri("..\\languages/Resource_Span.xaml", UriKind.Relative);
                    break;
                case "portugal":
                    resource.Source = new Uri("..\\languages/Resource_Portugal.xaml", UriKind.Relative);
                    break;
                case "japanees":
                    resource.Source = new Uri("..\\languages/Resource_Japanees .xaml", UriKind.Relative);
                    break;
                case "russian":
                    resource.Source = new Uri("..\\languages/Resource_Russian.xaml", UriKind.Relative);
                    break;
                case "urdu":
                    resource.Source = new Uri("..\\languages/Resource_Urdu.xaml", UriKind.Relative);
                    break;
                case "hebrew":
                    resource.Source = new Uri("..\\languages/Resource_Hebrew.xaml", UriKind.Relative);
                    break;
                case "french":
                    resource.Source = new Uri("..\\languages/Resource_French.xaml", UriKind.Relative);
                    break;

                case "china":
                    resource.Source = new Uri("..\\languages/Resource_China.xaml", UriKind.Relative);
                    break;




                default:
                
                    resource.Source = new Uri("..\\ResourceDictionares.en.xaml", UriKind.Relative);
                    break;

            }
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);


        }

   

        private void radGridView_SelectionChanged(object sender, SelectionChangeEventArgs e)
        {

        }

        private void RadMenuItem_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
         
        }

     

        private void btn_Dark_Green(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/System.Windows.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/Telerik.Windows.Controls.Input.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/Telerik.Windows.Controls.GridView.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/Telerik.Windows.Controls.Docking.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/Telerik.Windows.Controls.RibbonView.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/Telerik.Windows.Controls.Navigation.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/Telerik.Windows.Controls.Pivot.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Green;component/Themes/Telerik.Windows.Controls.Data.xaml", UriKind.Relative)

            });


        }

        private void btn_Blue(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Material;component/Themes/System.Windows.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Material;component/Themes/Telerik.Windows.Controls.Input.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Material;component/Themes/Telerik.Windows.Controls.GridView.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Material;component/Themes/Telerik.Windows.Controls.Docking.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Material;component/Themes/Telerik.Windows.Controls.RibbonView.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Material;component/Themes/Telerik.Windows.Controls.Navigation.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Material;component/Themes/Telerik.Windows.Controls.Pivot.xaml", UriKind.Relative)

            });

            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Telerik.Windows.Themes.Material;component/Themes/Telerik.Windows.Controls.Data.xaml", UriKind.Relative)

            });

        }

       



        private void btn_Dark(object sender, RoutedEventArgs e)
        {
            // Application.Current.Resources.MergedDictionaries.Clear();

            if (IsDark) 
            {
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Expression_Dark;component/Themes/System.Windows.xaml", UriKind.Relative)

                });

                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Expression_Dark;component/Themes/Telerik.Windows.Controls.Input.xaml", UriKind.Relative)

                });

                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Expression_Dark;component/Themes/Telerik.Windows.Controls.GridView.xaml", UriKind.Relative)

                });

                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Expression_Dark;component/Themes/Telerik.Windows.Controls.Docking.xaml", UriKind.Relative)

                });

                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Expression_Dark;component/Themes/Telerik.Windows.Controls.RibbonView.xaml", UriKind.Relative)

                });

                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Expression_Dark;component/Themes/Telerik.Windows.Controls.Navigation.xaml", UriKind.Relative)

                });

                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Expression_Dark;component/Themes/Telerik.Windows.Controls.Pivot.xaml", UriKind.Relative)

                });

                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Expression_Dark;component/Themes/Telerik.Windows.Controls.Data.xaml", UriKind.Relative)

                });





            }

          

        }

        private void btn_light(object sender, RoutedEventArgs e)
        {
             Application.Current.Resources.MergedDictionaries.Clear();
            SwitchLanguage("en");


        }


    }
}
