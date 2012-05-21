using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace inbox
{
    public partial class NewMail : Form
    {
        private string frommail = "", password ="", Smtp = "";
        private  int port;
        private  bool ssl;
        Attachment data;
        public NewMail(string fromMail, string password,  string smtp, int port, bool ssl)
        {
            InitializeComponent();
            this.frommail = fromMail;
            this.password = password;
            this.Smtp = smtp;
            this.port = port;
            this.ssl = ssl;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            MailAddress fromAddress = new MailAddress(frommail);
            MailAddress toAddress = new MailAddress(textBoxTO.Text);
            try
            {
                this.Cursor = Cursors.WaitCursor;

                var smtp = new SmtpClient
                {
                    Host = Smtp,
                    Port = port,
                    EnableSsl = ssl,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, password)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = textBoxsubject.Text,
                    Body = textBoxBody.Text
                })
                {
                    if (data != null)
                        message.Attachments.Add(data);
                    smtp.Send(message);
                }
                this.Cursor = Cursors.Default;
                MessageBox.Show("The mail has been send");
                
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
                
            }
            this.Close();

        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                data = new Attachment(openFileDialog1.FileName);
                labelFile.Text = openFileDialog1.FileName;
            }
        }

        private void NewMail_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.UsingBackground;

            labelTo.ForeColor = Properties.Settings.Default.UsingText;
            labelSubject.ForeColor = Properties.Settings.Default.UsingText;
            labelFile.ForeColor = Properties.Settings.Default.UsingText;

            buttonAddFile.BackColor = Properties.Settings.Default.UsingButton;
            buttonAddFile.ForeColor = Properties.Settings.Default.UsingText;

            buttonSend.BackColor = Properties.Settings.Default.UsingButton;
            buttonSend.ForeColor = Properties.Settings.Default.UsingText;


        }
    }
}
