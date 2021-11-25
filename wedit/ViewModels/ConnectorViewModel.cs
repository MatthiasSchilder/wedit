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
        public string IdFrom { get; set; }
        public string IdTo { get; set; }
    }
}
