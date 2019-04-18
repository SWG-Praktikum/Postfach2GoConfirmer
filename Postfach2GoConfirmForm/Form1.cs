using Postfach2goConfirmer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using static System.Windows.Forms.CheckedListBox;
using Newtonsoft.Json.Linq;

namespace Postfach2GoConfirmForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(CheckAllMails);
            aTimer.Interval = 10000;
            aTimer.Enabled = true;

            if (File.Exists("emails.json"))
            {
                JArray items = (JArray)JsonConvert.DeserializeObject(File.ReadAllText("emails.json"));
                foreach(var item in items)
                {
                    listbox_mails.Items.Add(item.ToString());
                }
            }

            if (File.Exists("emails-singleuse.json"))
            {
                JArray items = (JArray)JsonConvert.DeserializeObject(File.ReadAllText("emails-singleuse.json"));
                foreach(var item in items)
                {
                    listbox_singleusemails.Items.Add(item.ToString());
                }
            }
        }

        private void btn_generatemail_Click(object sender, EventArgs e)
        {
            string mailUser = Guid.NewGuid().ToString();
            string mail = mailUser + "@briefkasten2go.de";

            txt_generatedaddress.Text = mail;

            Clipboard.SetText(mail);
            listbox_mails.Items.Add(mail);
        }

        void CheckAllMails(object source, ElapsedEventArgs e)
        {
            foreach(string item in listbox_mails.Items)
            {
                MailConfirmer.Confirm(item);
            }
            for(int i = 0; i < listbox_singleusemails.Items.Count; i++)
            {
                if (listbox_singleusemails.Items[i].ToString().StartsWith("[COMPLETED] "))
                    continue;
                if (MailConfirmer.Confirm(listbox_singleusemails.Items[i].ToString()))
                {
                    listbox_singleusemails.Invoke((MethodInvoker)delegate
                    {
                        listbox_singleusemails.Items[i] = "[COMPLETED] " + listbox_singleusemails.Items[i].ToString();
                        listbox_singleusemails.Items[i] = listbox_singleusemails.Items[i];
                    });
                }
            }
        }

        private void listbox_mails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_mails.Items.Count > listbox_mails.SelectedIndex && listbox_mails.SelectedIndex >= 0)
            {
                txt_generatedaddress.Text = listbox_mails.Items[listbox_mails.SelectedIndex].ToString();
                listbox_singleusemails.ClearSelected();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string items = JsonConvert.SerializeObject(listbox_mails.Items);
            File.WriteAllText("emails.json", items);

            List<string> singleUseMails = new List<string>();
            foreach(string item in listbox_singleusemails.Items)
            {
                if (item.ToString().StartsWith("[COMPLETED] "))
                    continue;

                singleUseMails.Add(item);
            }

            items = JsonConvert.SerializeObject(singleUseMails);
            File.WriteAllText("emails-singleuse.json", items);
        }

        private void btn_generatesingleusemail_Click(object sender, EventArgs e)
        {
            string mailUser = Guid.NewGuid().ToString();
            string mail = mailUser + "@briefkasten2go.de";

            txt_generatedaddress.Text = mail;

            Clipboard.SetText(mail);
            listbox_singleusemails.Items.Add(mail);
        }

        private void listbox_singleusemails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_singleusemails.Items.Count > listbox_singleusemails.SelectedIndex && listbox_singleusemails.SelectedIndex >= 0)
            {
                txt_generatedaddress.Text = listbox_singleusemails.Items[listbox_singleusemails.SelectedIndex].ToString();
                listbox_mails.ClearSelected();
            }
        }
    }
}
