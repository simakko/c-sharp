using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ski_Jump_Point_Calculator
{
    public partial class Result : UserControl
    {
        private static Result _instance;

        public static Result Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Result();
                }
                return _instance;
            }
        }

        public Result()
        {
            InitializeComponent();
        }
    }
}
