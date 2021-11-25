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

namespace wedit
{
    /// <summary>
    /// Interaction logic for WorkflowItem3.xaml
    /// </summary>
    public partial class WorkflowItem3 : DragItem
    {
        public WidgetType ProcessorType { get; set; }
        public event MouseEventHandler ConnectionDrawingStarted;

        public bool HasInputConnector
        {
            get
            {
                if (ProcessorType == WidgetType.InputOnly || ProcessorType == WidgetType.InputAndOutput)
                    return true;
                return false;
            }
        }
        public bool HasOutputConnector
        {
            get
            {
                if (ProcessorType == WidgetType.OutputOnly || ProcessorType == WidgetType.InputAndOutput)
                    return true;
                return false;
            }
        }

        public Point PositionInputConnector
        {
            get
            {
                ApplyTemplate();
                var a = (Visual)GetTemplateChild("inboundConnector");
                var wnd = Application.Current.MainWindow;
                Point relativePoint = a.TransformToAncestor(wnd)
                              .Transform(new Point(0, 0));

                return relativePoint;
                //return out
            }
        }

        public Point PositionOutputConnector
        {
            get
            {
                ApplyTemplate();
                var a = (Visual) GetTemplateChild("outboundConnector");
                var wnd = Application.Current.MainWindow;
                Point relativePoint = a.TransformToAncestor(wnd)
                              .Transform(new Point(0, 0));

                return relativePoint;
                //return out
            }
        }

        public WorkflowItem3()
        {
            InitializeComponent();

            
        }


        protected override System.Windows.Media.HitTestResult HitTestCore(System.Windows.Media.PointHitTestParameters hitTestParameters)
        {
            return new PointHitTestResult(this, hitTestParameters.HitPoint);
        }

        private void outboundConnector_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(PositionOutputConnector.ToString());
        }


        //private void WorkflowConnector_Click(object sender, RoutedEventArgs e)
        //{
        //    ConnectionDrawingStarted?.Invoke(this, null);
        //}

        //private void WorkflowConnector_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    ConnectionDrawingStarted?.Invoke(this, null);
        //}
    }
}
