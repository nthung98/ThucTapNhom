using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThucTapNhom_XH
{
    class MyPB : PictureBox
    {
        int index = 0;


        public int Index { get => index; set => index = value; }

        int imageIndex = 0;
        public int ImageIndex { get => imageIndex; set => imageIndex = value; }

        public bool isMatch()
        {
            return (index == imageIndex);
        }
    }
}
