using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brew_s_ko
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private Form currentchildForm;
        public void OpenChildForm(Form childForm)
        {
            if (currentchildForm != null)
            {
                currentchildForm.Hide();
            }
            currentchildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
            /*childForm.Size = new Size(*//*Convert.ToInt32(childForm.Width * 1.155), Convert.ToInt32(childForm.Height * 1.096 - 5)*//*1400, 782);*/
            childForm.FormBorderStyle = FormBorderStyle.None;
            /*childForm.Location = new Point(xpos, ypos);*/
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory());   
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Homepage());
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Order());
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory());
        }
    }
}
