using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wedit.Model
{
    public class Connection
    {
        public Widget From { get; }
        public Widget To { get; }
        public Connection(Widget from, Widget to)
        {
            From = from;
            To = to;
        }
    }
}
