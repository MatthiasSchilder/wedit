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
        public ProcessorType ProcessorType { get; set; }
        public event MouseEventHandler ConnectionDrawingStarted;

        public bool HasInputConnector
        {
            get
            {
                if (ProcessorType == ProcessorType.InputOnly || ProcessorType == ProcessorType.InputAndOutput)
                    return true;
                return false;
            }
        }
        public bool HasOutputConnector
        {
            get
            {
                if (ProcessorType == ProcessorType.OutputOnly || ProcessorType == ProcessorType.InputAndOutput)
                    return true;
                return false;
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
