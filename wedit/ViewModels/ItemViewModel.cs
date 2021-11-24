using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wedit.ViewModels;
using Point = System.Windows.Point;
using Size = System.Windows.Size;

namespace wedit.ViewModels
{
    public class ItemViewModel : RenderableWorkflowPart
    {
        public Point Position { get; set; }
        public Size Size { get; set; }

        public bool HasInputConnector { get; set; }
        public Point? PositionInputConnector { get; }

        public bool HasOutputConnector { get; set; }
        public Point? PositionOutputConnector { get; }


        public ItemViewModel(Point position) : this(position, new Size(160, 90))
        {

        }

        public ItemViewModel(Point position, Size size)
        {
            Position = position;
            Size = size;
        }
    }
}
