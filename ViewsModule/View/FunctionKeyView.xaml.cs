using GalaSoft.MvvmLight.Messaging;
using System.Windows;
using System.Windows.Controls;
using ViewsModule.Messages;

namespace ViewsModule.View
{
    /// <summary>
    /// Interaction logic for FunctionKeyView.xaml
    /// </summary>
    public partial class FunctionKeyView : UserControl
    {
        public FunctionKeyView()
        {
            InitializeComponent();
        }

        private void noBarClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<GenericMessage<SystemState>>(new GenericMessage<SystemState>(SystemState.NoBar));
        }

        private void headDetClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<GenericMessage<SystemState>>(new GenericMessage<SystemState>(SystemState.HeadDet));
        }

        private void tailDetClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<GenericMessage<SystemState>>(new GenericMessage<SystemState>(SystemState.TailDet));
        }

        private void headCutDetClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<GenericMessage<SystemState>>(new GenericMessage<SystemState>(SystemState.HeadCutDet));
        }

        private void tailCutDetClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<GenericMessage<SystemState>>(new GenericMessage<SystemState>(SystemState.TailCutDet));
        }

        private void headDetTransitClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<GenericMessage<SystemState>>(new GenericMessage<SystemState>(SystemState.HeadDetTransit));
        }

        private void headDetTailCutClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<GenericMessage<SystemState>>(new GenericMessage<SystemState>(SystemState.HeadDetTailCut));
        }

        private void transitTailCutClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<GenericMessage<SystemState>>(new GenericMessage<SystemState>(SystemState.TransitTailCut));
        }
    }
}
