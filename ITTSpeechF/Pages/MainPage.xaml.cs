

using Microsoft.Maui.Controls;
using ITTSpeechF.Util.Recording.Windows;
using ITTSpeechF.Util.Requesting;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using ITTSpeechF.Controls.Popups;

namespace ITTSpeechF;

public partial class MainPage : ContentPage
{
    Recorder recorder;
    bool flagTapStatus = false;
    SPopup spopup;
    public MainPage()
    {
        InitializeComponent();
        spopup = new SPopup();
    }

    private void OnPointerEntered(object sender, PointerEventArgs e)
    {

        int a;

        spopup = new SPopup();
       



    }

    private void OnPointerExited(object sender, PointerEventArgs e)
    {
        if (recorder == null) return;

    }

    private void OnPointerMoved(object sender, PointerEventArgs e)
    {

    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (flagTapStatus)
        {
            micButton.Source = "https://i.imgur.com/Tgul0OQ.png";
            FileStream stream;

            recorder.Detener();
            flagTapStatus = false;

            string filePath = recorder.OutputFilePath;
            recorder.Dispose();
            byte[] fileBytes = File.ReadAllBytes(filePath);
            stream = new(filePath, FileMode.Open);
            Task.Run(() =>
            IttRequest.Upload("https://localhost:7058/analizar", "file", stream, fileBytes));


        }
        else
        {
            micButton.Source = "https://i.imgur.com/xHjH5ac.png";
            Task.Run(() =>
            {


                recorder = new Recorder();
                recorder.FileName = Guid.NewGuid().ToString() + DateTime.Now.Date.ToString("yyyy-mm-dd") + ".wav";
                recorder.Iniciar();
                flagTapStatus = true;
             
            });
          
        }
    }
}




