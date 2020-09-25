using Microsoft.Azure.Devices.Client;
using SharedLibrary.Models;
using SharedLibrary.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page

    {
        private static readonly string _conn = "HostName=Alex-win20-iothub.azure-devices.net;DeviceId=consoleapp;SharedAccessKey=Vx5YH1x8bEsBL0+jMGLHvgL2eJIwHNgsk2HmUNl2xjU=";
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);

            public  MainPage()
        {
            
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
 
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
        }
    }
}
