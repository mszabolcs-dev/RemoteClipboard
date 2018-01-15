namespace RemoteClipboard_example
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableNotificationFor1MinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_paste = new System.Windows.Forms.Button();
            this.groupBox_paste = new System.Windows.Forms.GroupBox();
            this.label_sec_paste = new System.Windows.Forms.Label();
            this.numericUpDown_paste = new System.Windows.Forms.NumericUpDown();
            this.groupBox_copy = new System.Windows.Forms.GroupBox();
            this.button_send = new System.Windows.Forms.Button();
            this.groupBox_setusername = new System.Windows.Forms.GroupBox();
            this.label_setusernamewarn = new System.Windows.Forms.Label();
            this.button_setusername = new System.Windows.Forms.Button();
            this.textBox_setusername = new System.Windows.Forms.TextBox();
            this.label_setusername = new System.Windows.Forms.Label();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox_paste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_paste)).BeginInit();
            this.groupBox_copy.SuspendLayout();
            this.groupBox_setusername.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.disableNotificationFor1MinToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(230, 120);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.copyToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.pasteToolStripMenuItem.Text = "Paste after  5 sec";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // disableNotificationFor1MinToolStripMenuItem
            // 
            this.disableNotificationFor1MinToolStripMenuItem.Name = "disableNotificationFor1MinToolStripMenuItem";
            this.disableNotificationFor1MinToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.disableNotificationFor1MinToolStripMenuItem.Text = "Disable Notification for 1 min";
            this.disableNotificationFor1MinToolStripMenuItem.Click += new System.EventHandler(this.disableNotificationFor1MinToolStripMenuItem_Click);
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(10, 25);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(85, 40);
            this.button_copy.TabIndex = 0;
            this.button_copy.Text = "Copy to Clipboard";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_paste
            // 
            this.button_paste.Location = new System.Drawing.Point(6, 45);
            this.button_paste.Name = "button_paste";
            this.button_paste.Size = new System.Drawing.Size(188, 32);
            this.button_paste.TabIndex = 1;
            this.button_paste.Text = "Paste after 5 seconds";
            this.button_paste.UseVisualStyleBackColor = true;
            this.button_paste.Click += new System.EventHandler(this.button_paste_Click);
            // 
            // groupBox_paste
            // 
            this.groupBox_paste.Controls.Add(this.label_sec_paste);
            this.groupBox_paste.Controls.Add(this.numericUpDown_paste);
            this.groupBox_paste.Controls.Add(this.button_paste);
            this.groupBox_paste.Location = new System.Drawing.Point(217, 12);
            this.groupBox_paste.Name = "groupBox_paste";
            this.groupBox_paste.Size = new System.Drawing.Size(200, 83);
            this.groupBox_paste.TabIndex = 2;
            this.groupBox_paste.TabStop = false;
            this.groupBox_paste.Text = "Paste";
            // 
            // label_sec_paste
            // 
            this.label_sec_paste.AutoSize = true;
            this.label_sec_paste.Location = new System.Drawing.Point(91, 21);
            this.label_sec_paste.Name = "label_sec_paste";
            this.label_sec_paste.Size = new System.Drawing.Size(47, 13);
            this.label_sec_paste.TabIndex = 3;
            this.label_sec_paste.Text = "seconds";
            // 
            // numericUpDown_paste
            // 
            this.numericUpDown_paste.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_paste.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_paste.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_paste.Name = "numericUpDown_paste";
            this.numericUpDown_paste.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown_paste.TabIndex = 2;
            this.numericUpDown_paste.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_paste.ValueChanged += new System.EventHandler(this.numericUpDown_paste_ValueChanged);
            // 
            // groupBox_copy
            // 
            this.groupBox_copy.Controls.Add(this.button_send);
            this.groupBox_copy.Controls.Add(this.button_copy);
            this.groupBox_copy.Location = new System.Drawing.Point(11, 12);
            this.groupBox_copy.Name = "groupBox_copy";
            this.groupBox_copy.Size = new System.Drawing.Size(200, 83);
            this.groupBox_copy.TabIndex = 3;
            this.groupBox_copy.TabStop = false;
            this.groupBox_copy.Text = "Copy and Send";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(104, 24);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(85, 41);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // groupBox_setusername
            // 
            this.groupBox_setusername.Controls.Add(this.label_setusernamewarn);
            this.groupBox_setusername.Controls.Add(this.button_setusername);
            this.groupBox_setusername.Controls.Add(this.textBox_setusername);
            this.groupBox_setusername.Controls.Add(this.label_setusername);
            this.groupBox_setusername.Location = new System.Drawing.Point(12, 12);
            this.groupBox_setusername.Name = "groupBox_setusername";
            this.groupBox_setusername.Size = new System.Drawing.Size(415, 239);
            this.groupBox_setusername.TabIndex = 4;
            this.groupBox_setusername.TabStop = false;
            // 
            // label_setusernamewarn
            // 
            this.label_setusernamewarn.AutoSize = true;
            this.label_setusernamewarn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label_setusernamewarn.Location = new System.Drawing.Point(6, 221);
            this.label_setusernamewarn.Name = "label_setusernamewarn";
            this.label_setusernamewarn.Size = new System.Drawing.Size(184, 13);
            this.label_setusernamewarn.TabIndex = 3;
            this.label_setusernamewarn.Text = "You can\'t change it until you restart it.";
            // 
            // button_setusername
            // 
            this.button_setusername.Location = new System.Drawing.Point(153, 115);
            this.button_setusername.Name = "button_setusername";
            this.button_setusername.Size = new System.Drawing.Size(125, 23);
            this.button_setusername.TabIndex = 0;
            this.button_setusername.Text = "Set";
            this.button_setusername.UseVisualStyleBackColor = true;
            this.button_setusername.Click += new System.EventHandler(this.button_setusername_Click);
            // 
            // textBox_setusername
            // 
            this.textBox_setusername.Location = new System.Drawing.Point(99, 89);
            this.textBox_setusername.Name = "textBox_setusername";
            this.textBox_setusername.Size = new System.Drawing.Size(229, 20);
            this.textBox_setusername.TabIndex = 1;
            // 
            // label_setusername
            // 
            this.label_setusername.AutoSize = true;
            this.label_setusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_setusername.ForeColor = System.Drawing.Color.Red;
            this.label_setusername.Location = new System.Drawing.Point(67, 21);
            this.label_setusername.Name = "label_setusername";
            this.label_setusername.Size = new System.Drawing.Size(303, 25);
            this.label_setusername.TabIndex = 0;
            this.label_setusername.Text = "Please set your username first";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(226, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 256);
            this.Controls.Add(this.groupBox_setusername);
            this.Controls.Add(this.groupBox_copy);
            this.Controls.Add(this.groupBox_paste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RemoteClipboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox_paste.ResumeLayout(false);
            this.groupBox_paste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_paste)).EndInit();
            this.groupBox_copy.ResumeLayout(false);
            this.groupBox_setusername.ResumeLayout(false);
            this.groupBox_setusername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_paste;
        private System.Windows.Forms.GroupBox groupBox_paste;
        private System.Windows.Forms.Label label_sec_paste;
        private System.Windows.Forms.NumericUpDown numericUpDown_paste;
        private System.Windows.Forms.GroupBox groupBox_copy;
        private System.Windows.Forms.GroupBox groupBox_setusername;
        private System.Windows.Forms.Label label_setusernamewarn;
        private System.Windows.Forms.Button button_setusername;
        private System.Windows.Forms.TextBox textBox_setusername;
        private System.Windows.Forms.Label label_setusername;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableNotificationFor1MinToolStripMenuItem;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

