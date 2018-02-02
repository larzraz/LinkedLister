using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLister
{
    public class LinkedList
    {
        private class ListItem
        {
            public object Item { get; }
            
            public ListItem Next { get; set; }

            public ListItem(object o)
            {
                Item = o;
               
            }
            public override string ToString()
            {
                return Item.ToString();
            }
        };
        private ListItem firstItem = null;
        private ListItem lastItem = null;
        private int itemCount = 0;
        public object First { get { if (firstItem == null) {
                        return null; } return firstItem.Item; } }
        public object Last
        {
            get
            {
                if (lastItem == null)
                {
                    return null;
                }
                { return lastItem.Item; }
            }
        }
        public int Count { get { return itemCount; } }

        public object Items(int index)
        {
            object item = null;
           if (Count >= index)
            {
            ListItem list = firstItem;
            for (int i = 0; i <= index; i++)
            {
                    item = list.Item;
                    list = list.Next;
                
            }
        }
            
            return item;
        }
        public void InsertFirst(object o)
        {
            
            ListItem add = new ListItem(o);

            if (Count == 0)
            {
                add.Next = firstItem;
                firstItem = add;
                lastItem = add;
            } else
            {
                add.Next = firstItem;
                firstItem = add;
               
            }
            
         
            itemCount++;
        }
        public void InsertLast(object o)
        {
            ListItem add = new ListItem(o);
           
            if(Count == 0)
            {
                add.Next = lastItem;
                lastItem = add;
                firstItem = add;
                
            } else
            {
                var current = lastItem;
                current.Next = add;
                current = add;
                lastItem = current;
            }
            
           
            itemCount++;
        }
       public void RemoveAt(int index)
        {
            
            
            
            //var remove = firstItem;
            //var beforeRemove = firstItem;
            ////if (Count >= index)
            //{
            //    ListItem list = firstItem;
            //    ListItem list2 = firstItem;
            //    for (int i = 0; i <= index; i++)
            //    {
            //        remove = list;
            //        list = list.Next;
            //    }
            //    for (int i = 0; i < index; i++)
            //    {
            //        beforeRemove = list2;
            //        list2 = list2.Next;
            //    }
            //    beforeRemove.Next = remove.Next;
           
            //    itemCount--;

            //}
        }
        public override string ToString()
        {
            return base.ToString();
        }



    }
}
