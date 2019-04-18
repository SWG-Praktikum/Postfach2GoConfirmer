namespace Postfach2GoConfirmForm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_generatemail = new System.Windows.Forms.Button();
            this.listbox_mails = new System.Windows.Forms.ListBox();
            this.txt_generatedaddress = new System.Windows.Forms.TextBox();
            this.btn_generatesingleusemail = new System.Windows.Forms.Button();
            this.listbox_singleusemails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_generatemail
            // 
            this.btn_generatemail.Location = new System.Drawing.Point(12, 253);
            this.btn_generatemail.Name = "btn_generatemail";
            this.btn_generatemail.Size = new System.Drawing.Size(148, 121);
            this.btn_generatemail.TabIndex = 0;
            this.btn_generatemail.Text = "Generate static Email";
            this.btn_generatemail.UseVisualStyleBackColor = true;
            this.btn_generatemail.Click += new System.EventHandler(this.btn_generatemail_Click);
            // 
            // listbox_mails
            // 
            this.listbox_mails.FormattingEnabled = true;
            this.listbox_mails.Location = new System.Drawing.Point(166, 253);
            this.listbox_mails.Name = "listbox_mails";
            this.listbox_mails.Size = new System.Drawing.Size(433, 121);
            this.listbox_mails.TabIndex = 1;
            this.listbox_mails.SelectedIndexChanged += new System.EventHandler(this.listbox_mails_SelectedIndexChanged);
            // 
            // txt_generatedaddress
            // 
            this.txt_generatedaddress.Location = new System.Drawing.Point(12, 380);
            this.txt_generatedaddress.Name = "txt_generatedaddress";
            this.txt_generatedaddress.ReadOnly = true;
            this.txt_generatedaddress.Size = new System.Drawing.Size(587, 20);
            this.txt_generatedaddress.TabIndex = 2;
            // 
            // btn_generatesingleusemail
            // 
            this.btn_generatesingleusemail.Location = new System.Drawing.Point(12, 12);
            this.btn_generatesingleusemail.Name = "btn_generatesingleusemail";
            this.btn_generatesingleusemail.Size = new System.Drawing.Size(148, 235);
            this.btn_generatesingleusemail.TabIndex = 3;
            this.btn_generatesingleusemail.Text = "Generate single-use Email";
            this.btn_generatesingleusemail.UseVisualStyleBackColor = true;
            this.btn_generatesingleusemail.Click += new System.EventHandler(this.btn_generatesingleusemail_Click);
            // 
            // listbox_singleusemails
            // 
            this.listbox_singleusemails.FormattingEnabled = true;
            this.listbox_singleusemails.Location = new System.Drawing.Point(166, 12);
            this.listbox_singleusemails.Name = "listbox_singleusemails";
            this.listbox_singleusemails.Size = new System.Drawing.Size(433, 238);
            this.listbox_singleusemails.TabIndex = 4;
            this.listbox_singleusemails.SelectedIndexChanged += new System.EventHandler(this.listbox_singleusemails_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 412);
            this.Controls.Add(this.listbox_singleusemails);
            this.Controls.Add(this.btn_generatesingleusemail);
            this.Controls.Add(this.txt_generatedaddress);
            this.Controls.Add(this.listbox_mails);
            this.Controls.Add(this.btn_generatemail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generatemail;
        private System.Windows.Forms.ListBox listbox_mails;
        private System.Windows.Forms.TextBox txt_generatedaddress;
        private System.Windows.Forms.Button btn_generatesingleusemail;
        private System.Windows.Forms.ListBox listbox_singleusemails;
    }
}

