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

namespace VertexFXClient.Trade
{
    /// <summary>
    /// Interaction logic for TradeView.xaml
    /// </summary>
    public partial class TradeView : UserControl
    {
        public TradeView()
        {
            InitializeComponent();
        }

        private void txt_note_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush redBrush = new SolidColorBrush(Colors.Red);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_note.Foreground = redBrush;
            txt_note.FontWeight = FontWeights.Bold;




        }

        private void txt_note_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush redBrush = new SolidColorBrush(Colors.Blue);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_note.Foreground = redBrush;
            txt_note.FontWeight = FontWeights.Normal;
        }

        private void Mouse_Enter_Hedge(object sender, MouseEventArgs e)
        {


            SolidColorBrush redBrush = new SolidColorBrush(Colors.Red);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_bkock_hedge.Foreground = redBrush;
            txt_bkock_hedge.FontWeight = FontWeights.Bold;

        }

        private void Mouse_Leave_Hedge(object sender, MouseEventArgs e)
        {
            SolidColorBrush redBrush = new SolidColorBrush(Colors.Blue);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_bkock_hedge.Foreground = redBrush;
            txt_bkock_hedge.FontWeight = FontWeights.Normal;
        }

        private void Mouse_Enter_Cancel(object sender, MouseEventArgs e)
        {
            SolidColorBrush redBrush = new SolidColorBrush(Colors.Red);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_block_Cancel.Foreground = redBrush;
            txt_block_Cancel.FontWeight = FontWeights.Bold;

        }

        private void Mouse_Leave_Cancel(object sender, MouseEventArgs e)
        {
            SolidColorBrush redBrush = new SolidColorBrush(Colors.Blue);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_block_Cancel.Foreground = redBrush;
            txt_block_Cancel.FontWeight = FontWeights.Normal;
        }
    }
}
