using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.IsolatedStorage;

namespace worldChamps
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

		// World series winners array

	string[] seriesWinners = 
	{ 
	"Boston Americans","New York Giants","Chicago White Sox",
	"Chicago Cubs","Chicago Cubs","Pittsburgh Pirates","Philadelphia Athletics",
	"Philadelphia Athletics","Boston Red Sox","Philadelphia Athletics","Boston Braves","Boston Red Sox",
	"Boston Red Sox","Chicago White Sox","Boston Red Sox","Cincinnati Reds","Cleveland Indians",
	"New York Giants","New York Giants","New York Yankees","Washington Senators","Pittsburgh Pirates",
	"St.Louis Cardinals","New York Yankees","New York Yankees","Philadelphia Athletics",
	"Philadelphia Athletics","St.Louis Cardinals","New York Yankees","New York Giants",
	"St.Louis Cardinals","Detroit Tigers","New York Yankees","New York Yankees",
	"New York Yankees","New York Yankees","Cincinnati Reds","New York Yankees",
	"St.Louis Cardinals","New York Yankees","St.Louis Cardinals","Detroit Tigers",
	"St.Louis Cardinals","New York Yankees","Cleveland Indians","New York Yankees",
	"New York Yankees","New York Yankees","New York Yankees",
	"New York Yankees","New York Giants","Brooklyn Dodgers","New York Yankees",
	"Milwaukee Braves","New York Yankees","Los Angeles Dodgers","Pittsburgh Pirates",
	"New York Yankees","New York Yankees","Los Angeles Dodgers",
	"St. Louis Cardinals","Los Angeles Dodgers","Baltimore Orioles","St. Louis Cardinals",
	"Detroit Tigers","New York Mets","Baltimore Orioles","Pittsburgh Pirates",
	"Oakland Athletics","Oakland Athletics","Oakland Athletics","Cincinnati Reds",
	"Cincinnati Reds","New York Yankees","New York Yankees","Pittsburgh Pirates",
	"Philadelphia Phillies","Los Angeles Dodgers","St.Louis Cardinals",
	"Baltimore Orioles","Detroit Tigers","Kansas City Royals","New York Mets",
	"Minnesota Twins","Los Angeles Dodgers","Oakland Athletics","Cincinnati Reds",
	"Minnesota Twins","Toronto Blue Jays","Toronto Blue Jays","Atlanta Braves",
	"New York Yankees","Florida Marlins","New York Yankees","New York Yankees",
	"New York Yankees","Arizona Diamondbacks","Anaheim Angels","Florida Marlins",
	"Boston Red Sox","Chicago White Sox","St. Louis Cardinals",
	"Boston Red Sox","Philadelphia Phillies",
	};

		private void calculate_Click(object sender, EventArgs e)
        {

				//initialize the count to 0
				int wins = 0;

				for (int i = 0; i < seriesWinners.Length; i++)
				{
					
					if (teamOptions.SelectedItem.ToString() == seriesWinners[i])
					{
						wins++;
					}
				}
				
				results.Text = Convert.ToString(wins);
			}

		// Clear button

		private void Clear_Click(object sender, EventArgs e)
		{
			results.Text = "";
		}

		// Exit button

		private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
