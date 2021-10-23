
using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Stopwatch sw = Stopwatch.StartNew();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void autocompleteMenu1_Selected(object sender, AutocompleteMenuNS.SelectedEventArgs e)
        {
            textBox1.AppendText(",");
        }

        static bool mailSent = false;
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                Console.WriteLine("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
            }
            else
            {
                //Console.WriteLine("Message sent.");
                MessageBox.Show("Message sent.");
            }
            mailSent = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Command line argument must the the SMTP host.
                SmtpClient client = new SmtpClient("tmbmail.techmanth.com");
                // Specify the e-mail sender.
                // Create a mailing address that includes a UTF8 character
                // in the display name.
                MailAddress from = new MailAddress("it.tmbmes@techmanth.com",
                   "Jane " + (char)0xD8 + " Clayton",
                System.Text.Encoding.UTF8);
                // Set destinations for the e-mail message.
                MailAddress to = new MailAddress("Wuttipong.T@techmanth.com");
                // Specify the message content.
                MailMessage message = new MailMessage(from, to);
                message.Body = "This is a test e-mail message sent by an application. ";
                // Include some non-ASCII characters in body and subject.
                string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
                message.Body += Environment.NewLine + someArrows;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Subject = "test message 1" + someArrows;
                message.SubjectEncoding = System.Text.Encoding.UTF8;
                // Set the method that is called back when the send operation ends.
                client.SendCompleted += new
                SendCompletedEventHandler(SendCompletedCallback);
                // The userState can be any object that allows your callback 
                // method to identify this send operation.
                // For this example, the userToken is a string constant.
                string userState = "test message1";
                client.SendAsync(message, userState);
                //Console.WriteLine("Sending message... press c to cancel mail. Press any other key to exit.");
                //client.SendAsyncCancel();
                // Clean up.
                //message.Dispose();
                //Console.WriteLine("Goodbye.");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
