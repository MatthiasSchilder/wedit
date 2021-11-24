using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wedit.ViewModels;
using Point = System.Windows.Point;

namespace wedit.ViewModels
{
    public class ConnectorViewModel : RenderableWorkflowPart
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }
        public Point P4 { get; set; }
    }
}
