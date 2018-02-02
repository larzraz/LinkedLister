using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLister
{
    class ListItems
    {
        public Object Item { get; }
        public ListItems Next { get; set; }
        public ListItems(Object o)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
