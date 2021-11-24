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

        public List<RenderableWorkflowPart> WorkflowParts
        {
            get
            {
                WorkflowParts.Clear();
                foreach(var widget in WorkflowModel.Widgets)
                {
                    WorkflowParts.Add(new ItemViewModel(widget.Position));
                }

                foreach(var connection in WorkflowModel.WidgetConnections)
                {

                }


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
            WorkflowModel.Widgets.Add(widgetStart);
            var widgetIntermediate = new Widget("Intermediate", WidgetType.InputAndOutput);
            WorkflowModel.Widgets.Add(widgetIntermediate);
            var widgetTermination = new Widget("Termination", WidgetType.InputOnly);
            WorkflowModel.Widgets.Add(widgetTermination);

            WorkflowModel.WidgetConnections.Add(new Connection(widgetStart, widgetIntermediate));
            WorkflowModel.WidgetConnections.Add(new Connection(widgetIntermediate, widgetTermination));
        }
    }
}
