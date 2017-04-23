using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskRadacode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextPage : ContentPage
    {
             //При створенні об'єкта класу я передаю йому масив,
            //значення якого необхідно вивести,
           //як послідовність Labels
            public NextPage(params string[] label)
            {
                InitializeComponent();
                StackLayout stackLayout = new StackLayout();
                stackLayout.BackgroundColor = Color.White;

                var MainTextLabel = new Label
                {
                    Text = "Данные бланка",
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Black,
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                };
                stackLayout.Children.Add(MainTextLabel);

                foreach (var cur in label)
                {
                    var textLabel = new Label
                    {
                        Text = cur,
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    };

                    stackLayout.Children.Add(textLabel);
                }
                Content = stackLayout;
        }
        
    }
}
