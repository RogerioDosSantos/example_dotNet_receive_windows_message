using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dot_net_application
{
    public partial class MainWindow : Form
    {
        private Label label1;
        private Label lblMessage;
        private const int _wm_user = 0x0400;
        private const int _message_for_action = _wm_user + 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private int _action_count = 0;
        private bool Action()
        {
            MessageBox.Show("Message Received\nPress OK to continue execution!");
            _action_count++;
            lblMessage.Text = "Executed Action " + _action_count.ToString() + " time(s)";
            return true;
        }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message message_received)
        {
            switch (message_received.Msg)
            {
                case _message_for_action:
                    Action();
                    break;
                default:
                    break;
            }
            base.WndProc(ref message_received);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(284, 42);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(308, 60);
            this.Controls.Add(this.lblMessage);
            this.Name = "MainWindow";
            this.Text = "dotNetApplicationWindowTitle";
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
