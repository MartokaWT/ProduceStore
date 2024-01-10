using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ProduceStore
{
	public partial class Form1 : Form
	{
		private const string produceSaveFilePath = "produceInfoSave.txt";
		string[] produceFileReadLines = File.ReadAllLines(produceSaveFilePath);
		private bool isDataLoaded = false;
		private bool isAvailable = false;

		public Form1()
		{
			InitializeComponent();
			UpdateScreen();
			CheckAvailability();
		}

		private void storeButton_Click(object sender, EventArgs e)
		{
			UpdateScreen();
			produceGridView.Show();
		}

		private void ordersButton_Click(object sender, EventArgs e)
		{
			produceGridView.Hide();
		}

		private void buyButton_Click(object sender, EventArgs e)
		{
			UpdateScreen();
		}

		private void UpdateScreen()
		{
			if (!isDataLoaded)
			{
				try
				{
					produceFileReadLines = File.ReadAllLines(produceSaveFilePath);

					produceGridView.Rows.Clear();

					foreach (string line in produceFileReadLines)
					{
						string[] data = line.Split(',');
						if (data.Length >= 4)
						{
							produceGridView.Rows.Add(data[0], data[1], data[2], data[3]);
						}
					}

					isDataLoaded = true;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error loading data: " + ex.Message);
				}
			}
		}

		private void CheckAvailability()
		{
			if (isAvailable == false)
			{
				try
				{
					UpdateScreen();

					foreach (string line in produceFileReadLines)
					{
						string[] data = line.Split(',');
					    
						for (int i = 0; i < produceGridView.Columns.Count; i++)
						{
							int produceAmount = int.Parse(data[1]);
							if (produceAmount < 1)
							{
								produceGridView.Rows[3].Cells[i].Value = "Out of Stock";
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error loading data: " + ex.Message);
				}
			}
		}
	}
}