using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ski_Jump_Point_Calculator
{
    public partial class ResultController : UserControl
    {
        public static List<Jumper> JumperList { get; set; }
        public static List<Result> ResultList { get; set; }
        public static List<Score> ScoreList { get; set; }
        private static ResultController _instance;
        public static ResultController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ResultController();
                }
                else
                {
                    _instance.Refresh();
                }
                return _instance;
            }
        }

        public ResultController()
        {
            InitializeComponent();
        }

        public void ShowScores()
        {
            returnGridView2.Rows.Clear();

            List<Result> scores = (from result in ResultList
                                  orderby result.Score descending
                                  select result).ToList();
            int i = 1;
            foreach (var score in scores)
            {
                object[] row = { i.ToString(), score.Name, score.Country, score.Score.ToString() };
                returnGridView2.Rows.Add(row);
                i++;
            }
        }
    }
}
