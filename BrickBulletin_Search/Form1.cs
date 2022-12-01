// Rose Silletto
// IGME 201 Group Project
// Brick Bulletin

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBulletin_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.searchButton.Click += new EventHandler(searchButton__Click);

        }
    }
}
