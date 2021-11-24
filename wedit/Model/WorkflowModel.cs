using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wedit.Model
{
    public class WorkflowModel
    {
        public List<Widget> Widgets { get; set; }
        public List<Connection> WidgetConnections { get; set; }

        public WorkflowModel()
        {
            Widgets = new List<Widget>();
            WidgetConnections = new List<Connection>();

        }
    }
}
