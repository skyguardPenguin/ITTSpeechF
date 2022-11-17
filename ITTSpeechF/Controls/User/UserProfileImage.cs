using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ellipse=  Microsoft.Maui.Controls.Shapes.Ellipse;

namespace ITTSpeechF.Controls.User
{
    public class UserProfileImage:Grid
    {
        public Border ProfileBorder { get; }
        public double BorderWidthRequest { get; set; } = 180;
        public double BorderHeightRequest { get; set; } = 180;
        public Color BorderBackgroundColor { get; set; } = Color.FromArgb("ada1c1");
        public Brush BorderStroke { get; set; } = new SolidColorBrush(Color.FromArgb("#5c4484"));
        public Thickness BorderMargin { get; set; } = new Thickness(0, 17, 0, 0);

        public Ellipse BorderStrokeShape { get; set; } = new Ellipse();

        public Image Image { get; }
        public string ImageSource { get; set; } = "https://i.imgur.com/QyDFHnn.png";
        public double ImageWidthRequest { get; set; } = 125;
        public double ImageHeightRequest { get; set; } = 134;
        public Aspect ImageAspect { get; set; } = Aspect.AspectFit;
        public LayoutOptions ImageVerticalOptions { get; set; } = LayoutOptions.Center;
        public Thickness ImageMargin { get; set; }= new Thickness(0, 17, 0, 0);
        public UserProfileImage()
        {
            VerticalOptions = LayoutOptions.Start;
            IsVisible = true;

            ProfileBorder = new Border();
            ProfileBorder.WidthRequest = BorderWidthRequest;
            ProfileBorder.HeightRequest = BorderHeightRequest;
            ProfileBorder.Stroke=BorderStroke;
            ProfileBorder.Margin = BorderMargin;
            ProfileBorder.StrokeShape = BorderStrokeShape;
            ProfileBorder.BackgroundColor = BorderBackgroundColor;

            Image = new Image();
           
            Image.Source = ImageSource;
            Image.WidthRequest = ImageWidthRequest;
            Image.HeightRequest = ImageHeightRequest;
            Image.Aspect = ImageAspect;
            Image.VerticalOptions= VerticalOptions;
            Image.Margin = ImageMargin;
           
        }
    }
}

//< Grid VerticalOptions = "Start" >

//            < Border
//                WidthRequest = "180"
//                HeightRequest = "180"
//                StrokeThickness = "5"
//                BackgroundColor = "#ada1c1"
//                Stroke = "#5c4484"
//                Margin = "0,17,0,0"


//                >
//                < Border.StrokeShape >
//                    < Ellipse ></ Ellipse >

//                </ Border.StrokeShape >



//            </ Border >
//            < Image Source = "https://i.imgur.com/QyDFHnn.png"
//                   WidthRequest = "125"
//                   HeightRequest = "134"
//                   Aspect = "AspectFit"
//                   VerticalOptions = "Center"
//                   Margin = "0,17,0,0" />
//        </ Grid >