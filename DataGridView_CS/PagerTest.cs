using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataGridView_CS.ucControl;

namespace DataGridView_CS
{
    public partial class PagerTest : Form
    {
        ButtonPager oPager = new ButtonPager();

        public PagerTest()
        {
            InitializeComponent();
            oPager.PageChanged += new EventHandler<PageChangedEventArgs>(PageChanged);
            panel1.Controls.Add(oPager);
            BindData(50, 1);
        }

        public void BindData(int totalrecord,int currentpage)
        {
            if (oPager != null)
                oPager.BindPager(totalrecord, currentpage);

        }

        private void PageChanged(object sender, PageChangedEventArgs e)
        {
            MessageBox.Show("Selected page index is " + e.CurrentPage.ToString());
            BindData(50, e.CurrentPage);
        }
    }
}
