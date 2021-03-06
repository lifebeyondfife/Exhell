﻿/*
  Copyright © Iain McDonald 2011
  
  This file is part of Exhell.

    Exhell is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Exhell is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Exhell.  If not, see <http://www.gnu.org/licenses/>.
*/
using System.Windows.Forms;
using System.Diagnostics;

namespace Exhell
{
    public partial class ExhellAbout : Form
    {
        public ExhellAbout()
        {
            InitializeComponent();
        }

        private void ExhellAboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.lifebeyondfife.com/");
        }
    }
}
