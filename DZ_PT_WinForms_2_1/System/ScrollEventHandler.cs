using System.Windows.Forms;

namespace System
{
    internal class ScrollEventHandler
    {
        private Action<object, ScrollEventArgs> richTextBox1_VScroll;

        public ScrollEventHandler(Action<object, ScrollEventArgs> richTextBox1_VScroll)
        {
            this.richTextBox1_VScroll = richTextBox1_VScroll;
        }
    }
}