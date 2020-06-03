using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyLogicUX
{
    public partial class SideMenuPanel : Form
    {
        public SideMenuPanel()
        {
            InitializeComponent();
        }

        private void customizeDesign()
        {

            smpanelMainMenu.Visible = true;
           // mmExit.Visible = true;
        }

        private void hideSubmenu()
        {
            if (smpanelMainMenu.Visible == true)
                smpanelMainMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenuName)
        {
            if (subMenuName.Visible == false)
            {
                hideSubmenu();
                subMenuName.Visible = true;

            }
            else
                subMenuName.Visible = false;  
        }

        private void mmMainMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(smpanelMainMenu);
        }

        private void smGo_Click(object sender, EventArgs e)
        {
            
        }

        private void smReset_Click(object sender, EventArgs e)
        {

        }

        private void mmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
