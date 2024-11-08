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

namespace MasinAl1.User_Controls
{
    /// <summary>
    /// Interaction logic for TextBoxWithPlaceholder.xaml
    /// </summary>
    public partial class TextBoxWithPlaceholder : UserControl
    {

        public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register("Text", typeof(string), typeof(TextBoxWithPlaceholder));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }


        public TextBoxWithPlaceholder()
        {
            InitializeComponent();
            placeholderTextBlock.Text = "Enter your gmail";
            UpdatePlaceholderVisibility();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdatePlaceholderVisibility();
        }

        private void UpdatePlaceholderVisibility()
        {
            placeholderTextBlock.Visibility = string.IsNullOrEmpty(textBox.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
