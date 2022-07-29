using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F.T.O_Templates_2._0
{
    public partial class MainForm : Form
    {
        private Button CurrentBtn;
        private Form activeForm;


        public MainForm()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnsender)
        {
            Color color = Color.Cyan;
            if (btnsender != null)
            {
                if (CurrentBtn != (Button)btnsender)
                {
                    DisableButton();
                    CurrentBtn = (Button)btnsender;
                    CurrentBtn.BackColor = color;
                    CurrentBtn.ForeColor = Color.White;
                    CurrentBtn.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DarkGreen;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelMain.Controls.Add(childForm);
            this.PanelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void trainingfiles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Training_Files_Form(), sender);
        }

        private void apps_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Applications_Form(),sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Forms.Form1 childForm = new Forms.Form1();
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelMain.Controls.Add(childForm);
            this.PanelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
