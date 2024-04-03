using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace AddressBook
{
    public partial class MainForm : Form
    {
        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            PanelMenu.Controls.Add(leftBorderBtn);
        }

        private struct RGBColors
        {
            // Buttons
            public static Color ButtonBackColorDefault = Color.FromArgb(5, 103, 251);
            public static Color ButtonTextColorDefault = Color.FromArgb(239, 244, 255);
            public static Color ButtonIconColorDefault = Color.FromArgb(239, 244, 255);

            public static Color ActiveButtonBackColor = Color.FromArgb(8, 56, 200);
            public static Color ActiveButtonTextColor = Color.FromArgb(239, 244, 255);
            public static Color ActiveButtonIconColor = Color.FromArgb(239, 244, 255);
            public static Color ButtonLeftBorderColor = Color.FromArgb(117, 149, 243);
        }

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Button
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = RGBColors.ActiveButtonBackColor;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                // Left Border for Button
                leftBorderBtn.BackColor = RGBColors.ButtonLeftBorderColor;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Title Bar
                iconCurrentChield.IconChar = currentButton.IconChar;
                titleOfCurChild.Text = currentButton.Text;
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = RGBColors.ButtonBackColorDefault;
                currentButton.ForeColor = RGBColors.ButtonTextColorDefault;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = RGBColors.ButtonIconColorDefault;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                leftBorderBtn.Visible = false;
            }
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Database());
        }

        private void DatabaseInfoButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void DatabaseAccessButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void ToHomeButton_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChield.IconChar = IconChar.Paypal;
            titleOfCurChild.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Form Managmant
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
