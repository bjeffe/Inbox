using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using OpenPop.Common.Logging;
using OpenPop.Pop3;
using System.IO;
using Message = OpenPop.Mime.Message;
using OpenPop.Pop3.Exceptions;
using OpenPop.Mime;
using OpenPop.Mime.Header;


namespace inbox
{
    public partial class Inbox : Form
    {
        private readonly Dictionary<int, Message> messages = new Dictionary<int, Message>();
        private readonly Pop3Client pop3Client;
        TreeNode node = new TreeNode();
        public Inbox()
        {
            InitializeComponent();

            DefaultLogger.SetLog(new FileLogger());

            // Enable file logging and include verbose information
            FileLogger.Enabled = true;
            FileLogger.Verbose = true;

            pop3Client = new Pop3Client();

            treeViewmails.AfterSelect += new TreeViewEventHandler(ListMessagesMessageSelected);
            treeViewFiles.AfterSelect +=new TreeViewEventHandler(ListAttachmentsAttachmentSelected);

            

            
        }
        private void SetStyle()
        {
            this.BackColor = Properties.Settings.Default.UsingBackground;

            labelpopserver.ForeColor = Properties.Settings.Default.UsingText;
            labelSTMPServer.ForeColor = Properties.Settings.Default.UsingText;
            labelUser.ForeColor = Properties.Settings.Default.UsingText;
            labelpopport.ForeColor = Properties.Settings.Default.UsingText;
            labelPass.ForeColor = Properties.Settings.Default.UsingText;
            labelSMTPPort.ForeColor = Properties.Settings.Default.UsingText;
            labelMailCount.ForeColor = Properties.Settings.Default.UsingText;


            checkBoxssl.ForeColor = Properties.Settings.Default.UsingText;

            buttonConnectandRetreive.ForeColor = Properties.Settings.Default.UsingText;
            buttonConnectandRetreive.BackColor = Properties.Settings.Default.UsingButton;

            buttonNewMail.ForeColor = Properties.Settings.Default.UsingText;
            buttonNewMail.BackColor = Properties.Settings.Default.UsingButton;

            menuStrip1.BackColor = Properties.Settings.Default.UsingBackground;
            menuStrip1.ForeColor = Properties.Settings.Default.UsingText;

            styleToolStripMenuItem.BackColor = Properties.Settings.Default.UsingBackground;
            styleToolStripMenuItem.ForeColor = Properties.Settings.Default.UsingText;

            defualToolStripMenuItem.BackColor = Properties.Settings.Default.UsingBackground;
            defualToolStripMenuItem.ForeColor = Properties.Settings.Default.UsingText;

            GreenToolStripMenuItem.BackColor = Properties.Settings.Default.UsingBackground;
            GreenToolStripMenuItem.ForeColor = Properties.Settings.Default.UsingText;

            redToolStripMenuItem.BackColor = Properties.Settings.Default.UsingBackground;
            redToolStripMenuItem.ForeColor = Properties.Settings.Default.UsingText;

            custoumToolStripMenuItem.BackColor = Properties.Settings.Default.UsingBackground;
            custoumToolStripMenuItem.ForeColor = Properties.Settings.Default.UsingText;

            useToolStripMenuItem.BackColor = Properties.Settings.Default.UsingBackground;
            useToolStripMenuItem.ForeColor = Properties.Settings.Default.UsingText;

            changeToolStripMenuItem.BackColor = Properties.Settings.Default.UsingBackground;
            changeToolStripMenuItem.ForeColor = Properties.Settings.Default.UsingText;

            exitToolStripMenuItem.BackColor = Properties.Settings.Default.UsingBackground;
            exitToolStripMenuItem.ForeColor = Properties.Settings.Default.UsingText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle();

            textBoxPopserver.Text = Properties.Settings.Default.PopServer;
            textBoxSMTPServer.Text = Properties.Settings.Default.SMTPServer;
            textBoxusername.Text = Properties.Settings.Default.User;
            textBoxPopPort.Text = Properties.Settings.Default.PopPort.ToString();
            textBoxSMTPport.Text = Properties.Settings.Default.SMTPPort.ToString();
            checkBoxssl.Checked = Properties.Settings.Default.SSL;

            Properties.Settings.Default.Save();

            //ReceiveMails();
        }

        private void ReceiveMails()
        {
            // Disable buttons while working
            //connectAndRetrieveButton.Enabled = false;
            //uidlButton.Enabled = false;
            

            try
            {

                if (pop3Client.Connected)
                    pop3Client.Disconnect();
                pop3Client.Connect(textBoxPopserver.Text, Convert.ToInt32(textBoxPopPort.Text), checkBoxssl.Checked);
                pop3Client.Authenticate(textBoxusername.Text, textBoxPass.Text);
                
                int count = pop3Client.GetMessageCount();
                textBoxcount.Text = count.ToString();
                textBoxMessage.Text = "";
                messages.Clear();
                treeViewmails.Nodes.Clear();
                treeViewFiles.Nodes.Clear();

                int success = 0;
                int fail = 0;
                for (int i = count; i >= 1; i -= 1)
                {
                    // Check if the form is closed while we are working. If so, abort
                    if (IsDisposed)
                        return;

                    // Refresh the form while fetching emails
                    // This will fix the "Application is not responding" problem
                    //Application.DoEvents();
                    try
                    {
                        Message message = pop3Client.GetMessage(i);

                        // Add the message to the dictionary from the messageNumber to the Message
                        messages.Add(i, message);

                        // Create a TreeNode tree that mimics the Message hierarchy
                        node = new TreeNodeBuilder().VisitMessage(message);

                        // Set the Tag property to the messageNumber
                        // We can use this to find the Message again later
                        node.Tag = i;

                        

                        success++;
                        backgroundWorkerGetMails.ReportProgress((int)(((double)(count - i) / count) * 100));
                    }
                    catch (Exception ex)
                    {
                        DefaultLogger.Log.LogError(
                            "TestForm: Message fetching failed: " + ex.Message + "\r\n" +
                            "Stack trace:\r\n" +
                            ex.StackTrace);
                        fail++;
                    }
                    

                    
                }
                
                MessageBox.Show(this, "Mail received!\nSuccesses: " + success + "\nFailed: " + fail, "Message fetching done");

                if (fail > 0)
                {
                    MessageBox.Show(this,
                                    "Since some of the emails were not parsed correctly (exceptions were thrown)\r\n" +
                                    "please consider sending your log file to the developer for fixing.\r\n" +
                                    "If you are able to include any extra information, please do so.",
                                    "Help improve OpenPop!");
                }
            }
            catch (InvalidLoginException)
            {
                MessageBox.Show(this, "The server did not accept the user credentials!", "POP3 Server Authentication");
            }
            catch (PopServerNotFoundException)
            {
                MessageBox.Show(this, "The server could not be found", "POP3 Retrieval");
            }
            catch (PopServerLockedException)
            {
                MessageBox.Show(this, "The mailbox is locked. It might be in use or under maintenance. Are you connected elsewhere?", "POP3 Account Locked");
            }
            catch (LoginDelayException)
            {
                MessageBox.Show(this, "Login not allowed. Server enforces delay between logins. Have you connected recently?", "POP3 Account Login Delay");
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Error occurred retrieving mail. " + e.Message, "POP3 Retrieval");
            }
            finally
            {
                // Enable the buttons again
               // connectAndRetrieveButton.Enabled = true;
                //uidlButton.Enabled = true;
                

            }
            progressBar.Visible = false;
        }

        private void ListAttachmentsAttachmentSelected(object sender, TreeViewEventArgs args)
        {
            // Fetch the attachment part which is currently selected
            MessagePart attachment = (MessagePart)treeViewFiles.SelectedNode.Tag;

            if (attachment != null)
            {
                saveFile.FileName = attachment.FileName;
                DialogResult result = saveFile.ShowDialog();
                if (result != DialogResult.OK)
                    return;

                // Now we want to save the attachment
                FileInfo file = new FileInfo(saveFile.FileName);

                // Check if the file already exists
                if (file.Exists)
                {
                    // User was asked when he chose the file, if he wanted to overwrite it
                    // Therefore, when we get to here, it is okay to delete the file
                    file.Delete();
                }

                // Lets try to save to the file
                try
                {
                    attachment.Save(file);

                    MessageBox.Show(this, "Attachment saved successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Attachment saving failed. Exception message: " + e.Message);
                }
            }
            else
            {
                MessageBox.Show(this, "Attachment object was null!");
            }
        }

        private static int GetMessageNumberFromSelectedNode(TreeNode node)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            // Check if we are at the root, by seeing if it has the Tag property set to an int
            if (node.Tag is int)
            {
                return (int)node.Tag;
            }

            // Otherwise we are not at the root, move up the tree
            return GetMessageNumberFromSelectedNode(node.Parent);
        }

        private void ListMessagesMessageSelected(object sender, TreeViewEventArgs e)
		{
			// Fetch out the selected message
			Message message = messages[GetMessageNumberFromSelectedNode(treeViewmails.SelectedNode)];

			// If the selected node contains a MessagePart and we can display the contents - display them
            if (treeViewmails.SelectedNode.Tag is MessagePart)
			{
                MessagePart selectedMessagePart = (MessagePart)treeViewmails.SelectedNode.Tag;
				if (selectedMessagePart.IsText)
				{
					// We can show text MessageParts
					textBoxMessage.Text = selectedMessagePart.GetBodyAsText();
				}
				else
				{
					// We are not able to show non-text MessageParts (MultiPart messages, images, pdf's ...)
                    textBoxMessage.Text = "<<OpenPop>> Cannot show this part of the email. It is not text <<OpenPop>>";
				}
			}
			else
			{
				// If the selected node is not a subnode and therefore does not
				// have a MessagePart in it's Tag property, we genericly find some content to show

				// Find the first text/plain version
				MessagePart plainTextPart = message.FindFirstPlainTextVersion();
				if (plainTextPart != null)
				{
					// The message had a text/plain version - show that one
                    textBoxMessage.Text = plainTextPart.GetBodyAsText();
				} else
				{
					// Try to find a body to show in some of the other text versions
					List<MessagePart> textVersions = message.FindAllTextVersions();
					if (textVersions.Count >= 1)
                        textBoxMessage.Text = textVersions[0].GetBodyAsText();
					else
                        textBoxMessage.Text = "<<OpenPop>> Cannot find a text version body in this message to show <<OpenPop>>";
				}
			}

			// Clear the attachment list from any previus shown attachments
            treeViewFiles.Nodes.Clear();

			// Build up the attachment list
			List<MessagePart> attachments = message.FindAllAttachments();
			foreach (MessagePart attachment in attachments)
			{
				// Add the attachment to the list of attachments
                TreeNode addedNode = treeViewFiles.Nodes.Add((attachment.FileName));

				// Keep a reference to the attachment in the Tag property
				addedNode.Tag = attachment;
			}

			// Only show that attachmentPanel if there is attachments in the message
			bool hadAttachments = attachments.Count > 0;
            treeViewFiles.Visible = hadAttachments;

			// Generate header table
			DataSet dataSet = new DataSet();
			DataTable table = dataSet.Tables.Add("Headers");
			table.Columns.Add("Header");
			table.Columns.Add("Value");

			DataRowCollection rows = table.Rows;

			// Add all known headers
			rows.Add(new object[] {"Content-Description", message.Headers.ContentDescription});
			rows.Add(new object[] {"Content-Id", message.Headers.ContentId});
			foreach (string keyword in message.Headers.Keywords) rows.Add(new object[] {"Keyword", keyword});
			foreach (RfcMailAddress dispositionNotificationTo in message.Headers.DispositionNotificationTo) rows.Add(new object[] {"Disposition-Notification-To", dispositionNotificationTo});
			foreach (Received received in message.Headers.Received) rows.Add(new object[] {"Received", received.Raw});
			rows.Add(new object[] {"Importance", message.Headers.Importance});
			rows.Add(new object[] {"Content-Transfer-Encoding", message.Headers.ContentTransferEncoding});
			foreach (RfcMailAddress cc in message.Headers.Cc) rows.Add(new object[] {"Cc", cc});
			foreach (RfcMailAddress bcc in message.Headers.Bcc) rows.Add(new object[] {"Bcc", bcc});
			foreach (RfcMailAddress to in message.Headers.To) rows.Add(new object[] { "To", to });
			rows.Add(new object[] {"From", message.Headers.From});
			rows.Add(new object[] {"Reply-To", message.Headers.ReplyTo});
			foreach (string inReplyTo in message.Headers.InReplyTo) rows.Add(new object[] {"In-Reply-To", inReplyTo});
			foreach (string reference in message.Headers.References) rows.Add(new object[] { "References", reference });
			rows.Add(new object[] {"Sender", message.Headers.Sender});
			rows.Add(new object[] {"Content-Type", message.Headers.ContentType});
			rows.Add(new object[] {"Content-Disposition", message.Headers.ContentDisposition});
			rows.Add(new object[] {"Date", message.Headers.Date});
			rows.Add(new object[] {"Date", message.Headers.DateSent});
			rows.Add(new object[] {"Message-Id", message.Headers.MessageId});
			rows.Add(new object[] {"Mime-Version", message.Headers.MimeVersion});
			rows.Add(new object[] {"Return-Path", message.Headers.ReturnPath});
			rows.Add(new object[] {"Subject", message.Headers.Subject});
			
			// Add all unknown headers
			foreach (string key in message.Headers.UnknownHeaders)
			{
				string[] values = message.Headers.UnknownHeaders.GetValues(key);
				if (values != null)
					foreach (string value in values)
					{
						rows.Add(new object[] {key, value});
					}
			}

			// Now set the headers displayed on the GUI to the header table we just generated
			//gridHeaders.DataMember = table.TableName;
			//gridHeaders.DataSource = dataSet;
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PopServer = textBoxPopserver.Text;
            Properties.Settings.Default.SMTPServer = textBoxSMTPServer.Text;
            Properties.Settings.Default.User = textBoxusername.Text;
            Properties.Settings.Default.PopPort = Convert.ToInt32(textBoxPopPort.Text);
            Properties.Settings.Default.SMTPPort = Convert.ToInt32(textBoxSMTPport.Text);
            Properties.Settings.Default.SSL = checkBoxssl.Checked;

            Properties.Settings.Default.Save();

            backgroundWorkerGetMails.RunWorkerAsync();

            //ReceiveMails();
        }

        private void buttonNewMail_Click(object sender, EventArgs e)
        {
            NewMail newmail = new NewMail(textBoxusername.Text, textBoxPass.Text, textBoxSMTPServer.Text, Convert.ToInt32(textBoxSMTPport.Text), checkBoxssl.Checked);
            newmail.Show();
        }

        private void backgroundWorkerGetMails_DoWork(object sender, DoWorkEventArgs e)
        {
            ReceiveMails();
        }

        private void backgroundWorkerGetMails_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                // Show the built node in our list of messages
                treeViewmails.Nodes.Add(node);
                progressBar.Visible = true;
                progressBar.Value = e.ProgressPercentage;
            }
            catch (Exception)
            { }
        }

        private void backgroundWorkerGetMails_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = 100;
        }

        private void defualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UsingBackground = Properties.Settings.Default.DefaultBackground;
            Properties.Settings.Default.UsingButton = Properties.Settings.Default.DefaultButton;
            Properties.Settings.Default.UsingText = Properties.Settings.Default.DefaultText;

            Properties.Settings.Default.Save();

            SetStyle();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UsingBackground = Properties.Settings.Default.GreenBackground;
            Properties.Settings.Default.UsingButton = Properties.Settings.Default.GreenButton;
            Properties.Settings.Default.UsingText = Properties.Settings.Default.GreenText;

            Properties.Settings.Default.Save();

            SetStyle();

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UsingBackground = Properties.Settings.Default.ReedBackground;
            Properties.Settings.Default.UsingButton = Properties.Settings.Default.ReedButton;
            Properties.Settings.Default.UsingText = Properties.Settings.Default.ReedText;

            Properties.Settings.Default.Save();

            SetStyle();
        }

        private void useToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UsingBackground = Properties.Settings.Default.CustomBackGround;
            Properties.Settings.Default.UsingButton = Properties.Settings.Default.CustomButton;
            Properties.Settings.Default.UsingText = Properties.Settings.Default.CustomText;

            Properties.Settings.Default.Save();

            SetStyle();

        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomColor cuscolor = new CustomColor();
            cuscolor.ShowDialog();




            Properties.Settings.Default.UsingBackground = Properties.Settings.Default.CustomBackGround;
            Properties.Settings.Default.UsingButton = Properties.Settings.Default.CustomButton;
            Properties.Settings.Default.UsingText = Properties.Settings.Default.CustomText;

            Properties.Settings.Default.Save();

            SetStyle();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
