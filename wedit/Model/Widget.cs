using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = System.Windows.Point;

namespace wedit.Model
{
    public class Widget
    {
        public string Name { get; }
        public WidgetType Type { get; }
        public Point Position { get; set; }

        public Widget(string name, WidgetType type)
        {
            Name = name;
            Type = type;
        }
    }
}
