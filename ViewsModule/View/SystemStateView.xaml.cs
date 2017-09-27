using GalaSoft.MvvmLight.Messaging;
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
using ViewsModule.Messages;

namespace ViewsModule.View
{
    /// <summary>
    /// Interaction logic for SystemStateView.xaml
    /// </summary>
    public partial class SystemStateView : UserControl
    {
        public void OnStateChange(GenericMessage<SystemState> msg)
        {
            switch(msg.Content)
            {
                case SystemState.HeadCutDet:
                    slab1.Visibility = Visibility.Hidden;
                    slab2.Visibility = Visibility.Hidden;
                    slab3.Visibility = Visibility.Visible;
                    lblMiddleBar.Content = "105342";
                    break;
                case SystemState.HeadDet:
                    slab1.Visibility = Visibility.Visible;
                    slab2.Visibility = Visibility.Hidden;
                    slab3.Visibility = Visibility.Hidden;
                    lblMiddleBar.Content = "105342";
                    break;
                case SystemState.HeadDetTailCut:
                    slab1.Visibility = Visibility.Visible;
                    slab2.Visibility = Visibility.Hidden;
                    slab3.Visibility = Visibility.Visible;
                    lblMiddleBar.Content = "105342";
                    break;
                case SystemState.HeadDetTransit:
                    slab1.Visibility = Visibility.Visible;
                    slab2.Visibility = Visibility.Visible;
                    slab3.Visibility = Visibility.Hidden;
                    lblMiddleBar.Content = "105342";
                    break;
                case SystemState.NoBar:
                    slab1.Visibility = Visibility.Hidden;
                    slab2.Visibility = Visibility.Hidden;
                    slab3.Visibility = Visibility.Hidden;
                    lblMiddleBar.Content = "105342";
                    break;
                case SystemState.TailCutDet:
                    slab1.Visibility = Visibility.Hidden;
                    slab2.Visibility = Visibility.Hidden;
                    slab3.Visibility = Visibility.Hidden;
                    lblMiddleBar.Content = "105342";
                    break;
                case SystemState.TailDet:
                    slab1.Visibility = Visibility.Hidden;
                    slab2.Visibility = Visibility.Visible;
                    slab3.Visibility = Visibility.Hidden;
                    lblMiddleBar.Content = "105342";
                    break;
                case SystemState.TransitTailCut:
                    slab1.Visibility = Visibility.Hidden;
                    slab2.Visibility = Visibility.Visible;
                    slab3.Visibility = Visibility.Visible;
                    lblMiddleBar.Content = "105341";
                    break;
                default:
                    break;
            }
        }

        public SystemStateView()
        {
            InitializeComponent();
            Messenger.Default.Register<GenericMessage<SystemState>>(this, OnStateChange);
        }
    }
}
