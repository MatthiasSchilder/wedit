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
    /// Interaction logic for WorkflowConnector.xaml
    /// </summary>
    public partial class WorkflowConnector : Button
    {
        public WorkflowConnector()
        {
            InitializeComponent();
        }

        protected override System.Windows.Media.HitTestResult HitTestCore(System.Windows.Media.PointHitTestParameters hitTestParameters)
        {
            return new PointHitTestResult(this, hitTestParameters.HitPoint);
        }

        private void button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = false;
        }
    }
}
