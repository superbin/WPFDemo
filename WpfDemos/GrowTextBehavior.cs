using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace WpfDemos
{
    public class GrowTextBehavior : Behavior<TextBlock>
    {
        public int GrowBySize { get; set; }
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseEnter += AssociatedObject_MouseEnter;
            AssociatedObject.MouseLeave += AssociatedObject_MouseLeave;
        }

        private void AssociatedObject_MouseLeave(object sender, MouseEventArgs e)
        {
            AssociatedObject.FontSize -= GrowBySize;
        }

        private void AssociatedObject_MouseEnter(object sender, MouseEventArgs e)
        {
            AssociatedObject.FontSize += GrowBySize;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
        }
    }
}
