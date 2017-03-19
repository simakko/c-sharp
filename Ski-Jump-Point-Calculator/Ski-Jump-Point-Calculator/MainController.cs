using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ski_Jump_Point_Calculator
{
    public partial class MainController : Form
    {

        public MainController()
        {
            InitializeComponent();
        }

        public List<Jumper> JumperList = new List<Jumper>();
        public List<Result> ResultList = new List<Result>();
        public List<Score> ScoreList = new List<Score>();



        private void btnJumpers_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mainPanel.Controls.Contains(JumperController.Instance))
                {
                    JumperController.JumperList = JumperList;
                    mainPanel.Controls.Add(JumperController.Instance);
                    JumperController.Instance.Dock = DockStyle.Fill;
                    JumperController.Instance.BringToFront();
                }
                else
                {
                    JumperController.Instance.BringToFront();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mainPanel.Controls.Contains(PointsController.Instance))
                {
                    PointsController.JumperList = JumperList;
                    PointsController.ResultList = ResultList;
                    mainPanel.Controls.Add(PointsController.Instance);
                    PointsController.Instance.Dock = DockStyle.Fill;
                    PointsController.Instance.NameListUpdate();
                    PointsController.Instance.BringToFront();
                }
                else
                {
                    PointsController.Instance.NameListUpdate();
                    PointsController.Instance.BringToFront();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mainPanel.Controls.Contains(ResultController.Instance))
                {
                    ResultController.JumperList = JumperList;
                    ResultController.ResultList = ResultList;
                    ResultController.ScoreList = ScoreList;
                    mainPanel.Controls.Add(ResultController.Instance);
                    ResultController.Instance.Dock = DockStyle.Fill;
                    ResultController.Instance.ShowScores();
                    ResultController.Instance.BringToFront();
                }
                else
                {
                    ResultController.Instance.ShowScores();
                    ResultController.Instance.BringToFront();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }



    }
}
