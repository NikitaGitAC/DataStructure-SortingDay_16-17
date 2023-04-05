using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Binarytree
{
    public class binarytreecode
    {
        public node Root { get; set; }

        public bool Add(int value)
        {
            node before = null, after = this.Root;
            while (after != null)
            {
                before = after;
                if (value < after.Data)
                {
                    after = after.LeftNode;

                }
                else if (value > after.Data)
                {
                    after = after.RightNode;
                }
                else
                {
                    return false;
                }

            }
            node newnode = new node();
            newnode.Data = value;
            if (this.Root == null)
            {
                this.Root = newnode;
            }
            else
            {
                if (value < before.Data)
                {
                    before.leftnode = newnode;
                }
                else
                {
                    before.RightNode = newnode;
                }
            }
        
                   return true;

        }
              public void TravarsePreorder(node parent)
              {
                 if (parent != null)
                 {
                 Console.WriteLine(parent.Data + "");
                 TravarsePreorder(parent.LeftNode);
                 TravarsePreorder(parent.RightNode);
                 }
              }

    }
   

}

