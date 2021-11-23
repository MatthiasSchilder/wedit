using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace wedit
{
    public partial class DragItem : UserControl
    {
        protected Boolean isDragging;
        private Point mousePosition;
        private Double prevX, prevY;

        public DragItem()
        {
            //this.MouseLeftButtonDown += UserControl_MouseLeftButtonDown;
            //this.MouseLeftButtonUp += UserControl_MouseLeftButtonUp;
            //this.MouseMove += UserControl_MouseMove;
        }

        private void UserControl_MouseLeftButtonDown(Object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            var draggableControl = (sender as UserControl);
            mousePosition = e.GetPosition(Parent as UIElement);
            draggableControl.CaptureMouse();
        }

        private void UserControl_MouseLeftButtonUp(Object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
            var draggable = (sender as UserControl);
            var transform = (draggable.RenderTransform as TranslateTransform);
            if (transform != null)
            {
                prevX = transform.X;
                prevY = transform.Y;
            }
            draggable.ReleaseMouseCapture();
        }

        private void UserControl_MouseMove(Object sender, MouseEventArgs e)
        {
            var draggableControl = (sender as UserControl);
            if (isDragging && draggableControl != null)
            {
                var currentPosition = e.GetPosition(Parent as UIElement);
                var transform = (draggableControl.RenderTransform as TranslateTransform);
                if (transform == null)
                {
                    transform = new TranslateTransform();
                    draggableControl.RenderTransform = transform;
                }
                transform.X = (currentPosition.X - mousePosition.X);
                transform.Y = (currentPosition.Y - mousePosition.Y);
                if (prevX > 0)
                {
                    transform.X += prevX;
                    transform.Y += prevY;
                }
            }
        }
    }
}
