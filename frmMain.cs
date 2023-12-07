using System;
using System.Drawing;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmMain : Form
    {
        private void _OpenForm(Form frm)
        {
            if (frmPrev != null)
                frmPrev.Close();// delete prev form to make the application faster

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.BringToFront();
            frmPrev = frm;
            panelScreens.Controls.Add(frm);
            frm.Show();
        }
        private void _OpenScreen(Form frm, Button btn, Color LightColor, Color DarkColor)
        {
            if (_ActiveBtn != null)
            {
                _ActiveBtn.ForeColor = Color.Black;
                _ActiveBtn.BackColor = Color.WhiteSmoke;
            }

            lblLineOnTheLeftBtn.Visible = true;
            lblLineOnTheLeftBtn.Location = btn.Location;
            lblLineOnTheLeftBtn.BackColor = DarkColor;

            btn.BackColor = Color.Gainsboro;
            btn.ForeColor = DarkColor;
            lblScreenTitle.Text = frm.Text;
            lblScreenTitle.BackColor = DarkColor;
            _OpenForm(frm);
        }
        private Button _ActiveBtn = null;
        public frmMain()
        {
            InitializeComponent();
        }
        Form frmPrev = null;

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            _OpenScreen(frm, (Button)sender, Color.Aquamarine, Color.MediumAquamarine);
            _ActiveBtn = (Button)sender;
        }
        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            _OpenScreen(frm, (Button)sender, Color.IndianRed, Color.Brown);
            _ActiveBtn = (Button)sender;
        }
        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            _OpenScreen(frm, (Button)sender, Color.DarkMagenta, Color.Purple);
            _ActiveBtn = (Button)sender;
        }
    }
}
