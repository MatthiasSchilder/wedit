using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using wedit.Model;
using Point = System.Windows.Point;

namespace wedit.ViewModels
{
    public class WorkflowCanvasViewModel
    {
        public WorkflowModel WorkflowModel { get; }

        private List<RenderableWorkflowPart> _workflowParts = new List<RenderableWorkflowPart>();
        public List<RenderableWorkflowPart> WorkflowParts
        {
            get
            {
                _workflowParts.Clear();
                foreach(var widget in WorkflowModel.Widgets)
                {
                    _workflowParts.Add(new ItemViewModel(widget.Position));
                }

                foreach (var connection in WorkflowModel.WidgetConnections)
                {

                }
                return _workflowParts;

            }
        }


        public WorkflowCanvasViewModel()
        {
            WorkflowModel = new WorkflowModel();
            FillTestWorkflowModel();
        }

        private void FillTestWorkflowModel()
        {
            var widgetStart = new Widget("Start", WidgetType.OutputOnly);
            widgetStart.Position = new Point(100, 100);
            WorkflowModel.Widgets.Add(widgetStart);
            var widgetIntermediate = new Widget("Intermediate", WidgetType.InputAndOutput);
            widgetIntermediate.Position = new Point(300, 100);
            WorkflowModel.Widgets.Add(widgetIntermediate);
            var widgetTermination = new Widget("Termination", WidgetType.InputOnly);
            widgetTermination.Position = new Point(300, 300);
            WorkflowModel.Widgets.Add(widgetTermination);

            WorkflowModel.WidgetConnections.Add(new Connection(widgetStart, widgetIntermediate));
            WorkflowModel.WidgetConnections.Add(new Connection(widgetIntermediate, widgetTermination));
        }
    }
}
