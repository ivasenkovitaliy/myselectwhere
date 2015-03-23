using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace select_where
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //var startList = new List<int>() {3,2,1,5};
            var startList = new int[] {1, 2, 3, 5};

            var select = startList.Select(n => n*n);
            var mySelect = startList.MySelect(n => n*n);
            
            var where = startList.Where(n => n < 4);
            var myWhere = startList.MyWhere(n => n < 4);

            InitializeComponent();
        }
    }
}
