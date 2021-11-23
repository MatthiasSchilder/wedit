using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace wedit
{
    public class WorkflowCanvas : Canvas
    {
        private bool _isConnectionMode = false;

        public WorkflowCanvas()
        {
            this.MouseDown += WorkflowCanvas_MouseDown;
            this.MouseMove += WorkflowCanvas_MouseMove;
            this.MouseUp += WorkflowCanvas_MouseUp;
        }

        private void WorkflowCanvas_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var element = this.InputHitTest(e.GetPosition(this));
            Debug.WriteLine(element.GetType());
            if(element is WorkflowConnector)
            {
                BeginConnectionMode();
            }
        }


        private void WorkflowCanvas_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var element = this.InputHitTest(e.GetPosition(this));
            Debug.WriteLine(element.GetType());
            bool persistConnection = false;
            if (element is WorkflowConnector)
            {
                persistConnection = true; ;
            }
            EndConnectionMode(persistConnection);
        }

        private System.Windows.Shapes.Line lastLine;
        private void WorkflowCanvas_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if(_isConnectionMode)
            {
                if(lastLine == null)
                {
                    lastLine = new System.Windows.Shapes.Line();
                    lastLine.IsHitTestVisible = false;
                    lastLine.Stroke = Brushes.Red;
                    lastLine.StrokeEndLineCap = PenLineCap.Triangle;
                    lastLine.StrokeThickness = 1.5;
                    var mousePos = e.GetPosition(this);
                    lastLine.X1 = mousePos.X;
                    lastLine.Y1 = mousePos.Y;

                    lastLine.X2 = mousePos.X;
                    lastLine.Y2 = mousePos.Y;

                    this.Children.Add(lastLine);
                }
                else
                {
                    var mousePos = e.GetPosition(this);

                    lastLine.X2 = mousePos.X;
                    lastLine.Y2 = mousePos.Y;
                    
                }
            }
        }
        
        private void BeginConnectionMode()
        {
            _isConnectionMode = true;
        }

        private void EndConnectionMode(bool persistConnection)
        {
            if (_isConnectionMode)
            {
                _isConnectionMode = false;
                if (!persistConnection && lastLine != null)
                    this.Children.Remove(lastLine);
                lastLine = null;
            }
        }
    }
}
