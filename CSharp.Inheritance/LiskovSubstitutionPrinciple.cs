using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class LiskovSubstitutionPrinciple
    {
        public class Rectangle
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public Rectangle()
            {
                Height = 0;
                Width = 0;
            }
            public virtual void SetHeight(int height)
            {
                Height = height;
            }
            public virtual void SetWidth(int width)
            {
                Width = width;
            }
        }
        /// <summary>
        /// Design the sub-class square in such a way that it parent's class native methods should work fine with this sub-class also.
        /// </summary>
        public class Square:Rectangle
        {
            public Square()
            {
                Height = 0;
                Width= 0;
            }
            public override void SetHeight(int height)
            {
                Height= height;
                Width = height;
            }
            public new void SetWidth(int width)
            {
                Width = width;
                Height = width;
            }
        }
    }
}
