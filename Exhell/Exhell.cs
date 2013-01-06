/*
  Copyright © Iain McDonald 2011
  
  This file is part of Exhell.

	Foobar is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	Foobar is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with Exhell.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Exhell
{
	public partial class Exhell : Form
	{
		private ExhellAbout about;

		public Exhell()
		{
			InitializeComponent();
		}

		private void About_Disposed(object sender, EventArgs e)
		{
			if (about != null)
				this.about.Close();
			this.about = null;
		}

		private void ConvertClipboardData(object sender, EventArgs e)
		{
			string convertedString = ConvertedClipboardString();
			if (!string.IsNullOrEmpty(convertedString))
				Clipboard.SetData(DataFormats.Text, convertedString);
		}

		private void ExcelDate_MouseMove(object sender, MouseEventArgs e)
		{
			var convertedString = ConvertedClipboardString();
			this.excelDate.Text = string.IsNullOrEmpty(convertedString) ? "Exhell" : convertedString;
		}

		public string ConvertedClipboardString()
		{
			IDataObject clipboardData;
			try
			{
				clipboardData = Clipboard.GetDataObject();
			}
			catch (ExternalException)
			{
				// Problem accessing clipboard
				return null;
			}

			if (clipboardData != null && clipboardData.GetDataPresent(DataFormats.Text))
			{
				DateTime dateTime;
				var clipboardString = (string) clipboardData.GetData(DataFormats.Text);
				double result;

				if (double.TryParse(clipboardString, out result))
				{
					try
					{
						return DateTime.FromOADate(result).ToString(CultureInfo.InvariantCulture);
					}
					catch (ArgumentException)
					{
						// Clipboard data is not a valid OA date
						return null;
					}
				}
				
				if (DateTime.TryParse(clipboardString, out dateTime))
				{
					return dateTime.ToOADate().ToString(CultureInfo.InvariantCulture);
				}
			}

			return null;
		}

		private void Exhell_Closing(object sender, FormClosingEventArgs e)
		{
			Hide();
			WindowState = FormWindowState.Minimized;
		}

		private void Exhell_Shown(object sender, EventArgs e)
		{
			Hide();
		}

		private void ExhellAbout_Click(object sender, EventArgs e)
		{
			if (this.about == null)
			{
				this.about = new ExhellAbout();
				this.about.Disposed += this.About_Disposed;
			}
			this.about.Show();
		}

		private void ExhellExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void ExhellResize(object sender, EventArgs e)
		{
			if (FormWindowState.Minimized != WindowState)
				return;

			ShowInTaskbar = false;
			Hide();
		}
	}
}
