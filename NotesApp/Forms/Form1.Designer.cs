namespace NotesApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelSetAlarm = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelCurrentTimeTxt = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNoteList = new System.Windows.Forms.TabPage();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.noteListDraft = new NotesApp.Controls.NoteList();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.noteListInProgress = new NotesApp.Controls.NoteList();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.noteListDone = new NotesApp.Controls.NoteList();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.noteListDeleted = new NotesApp.Controls.NoteList();
            this.TabAlarm = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDownHour2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownMin2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.labelEdit2 = new System.Windows.Forms.Label();
            this.labelLock2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDownHour1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMin1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEdit1 = new System.Windows.Forms.Label();
            this.labelLock1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPostpone = new System.Windows.Forms.Label();
            this.TabInfo = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelVerVal = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabControl1.SuspendLayout();
            this.tabNoteList.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.TabAlarm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin2)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.TabInfo.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSetAlarm
            // 
            this.labelSetAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSetAlarm.AutoSize = true;
            this.labelSetAlarm.BackColor = System.Drawing.Color.Transparent;
            this.labelSetAlarm.Location = new System.Drawing.Point(114, 57);
            this.labelSetAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.labelSetAlarm.Name = "labelSetAlarm";
            this.labelSetAlarm.Size = new System.Drawing.Size(82, 20);
            this.labelSetAlarm.TabIndex = 0;
            this.labelSetAlarm.Text = "Set Alarm";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.CustomFormat = "hh:mm:ss tt";
            this.dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(398, 53);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(134, 28);
            this.dateTimePicker.TabIndex = 6;
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentTime.Location = new System.Drawing.Point(101, 192);
            this.labelCurrentTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(108, 20);
            this.labelCurrentTime.TabIndex = 4;
            this.labelCurrentTime.Text = "Current Time";
            // 
            // labelCurrentTimeTxt
            // 
            this.labelCurrentTimeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentTimeTxt.AutoSize = true;
            this.labelCurrentTimeTxt.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentTimeTxt.Location = new System.Drawing.Point(410, 192);
            this.labelCurrentTimeTxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCurrentTimeTxt.MinimumSize = new System.Drawing.Size(110, 0);
            this.labelCurrentTimeTxt.Name = "labelCurrentTimeTxt";
            this.labelCurrentTimeTxt.Size = new System.Drawing.Size(110, 20);
            this.labelCurrentTimeTxt.TabIndex = 6;
            this.labelCurrentTimeTxt.Text = "Current Time";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNoteList);
            this.tabControl1.Controls.Add(this.TabAlarm);
            this.tabControl1.Controls.Add(this.TabInfo);
            this.tabControl1.Location = new System.Drawing.Point(15, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(3, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 458);
            this.tabControl1.TabIndex = 7;
            // 
            // tabNoteList
            // 
            this.tabNoteList.Controls.Add(this.buttonAddNote);
            this.tabNoteList.Controls.Add(this.tabControl2);
            this.tabNoteList.Location = new System.Drawing.Point(4, 29);
            this.tabNoteList.Name = "tabNoteList";
            this.tabNoteList.Padding = new System.Windows.Forms.Padding(3);
            this.tabNoteList.Size = new System.Drawing.Size(639, 425);
            this.tabNoteList.TabIndex = 3;
            this.tabNoteList.Text = "Note";
            this.tabNoteList.UseVisualStyleBackColor = true;
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNote.Location = new System.Drawing.Point(521, 3);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(109, 27);
            this.buttonAddNote.TabIndex = 7;
            this.buttonAddNote.Text = "Add note";
            this.buttonAddNote.UseVisualStyleBackColor = true;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(627, 386);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.noteListDraft);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(619, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Draft";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // noteListDraft
            // 
            this.noteListDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteListDraft.DeleteLableText = "Delete";
            this.noteListDraft.FilterStatus = NotesApp.NoteStatus.Draft;
            this.noteListDraft.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.noteListDraft.Location = new System.Drawing.Point(0, 0);
            this.noteListDraft.Margin = new System.Windows.Forms.Padding(0);
            this.noteListDraft.Name = "noteListDraft";
            this.noteListDraft.Size = new System.Drawing.Size(619, 367);
            this.noteListDraft.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.noteListInProgress);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "In-Progress";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // noteListInProgress
            // 
            this.noteListInProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteListInProgress.DeleteLableText = "Delete";
            this.noteListInProgress.FilterStatus = NotesApp.NoteStatus.Draft;
            this.noteListInProgress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.noteListInProgress.Location = new System.Drawing.Point(0, 0);
            this.noteListInProgress.Margin = new System.Windows.Forms.Padding(0);
            this.noteListInProgress.Name = "noteListInProgress";
            this.noteListInProgress.Size = new System.Drawing.Size(619, 500);
            this.noteListInProgress.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.noteListDone);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(619, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Done";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // noteListDone
            // 
            this.noteListDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteListDone.DeleteLableText = "Delete";
            this.noteListDone.FilterStatus = NotesApp.NoteStatus.Draft;
            this.noteListDone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.noteListDone.Location = new System.Drawing.Point(0, 0);
            this.noteListDone.Margin = new System.Windows.Forms.Padding(0);
            this.noteListDone.Name = "noteListDone";
            this.noteListDone.Size = new System.Drawing.Size(619, 500);
            this.noteListDone.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.noteListDeleted);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(619, 353);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Deleted";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // noteListDeleted
            // 
            this.noteListDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteListDeleted.DeleteLableText = "Clear";
            this.noteListDeleted.FilterStatus = NotesApp.NoteStatus.Draft;
            this.noteListDeleted.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.noteListDeleted.Location = new System.Drawing.Point(0, 0);
            this.noteListDeleted.Margin = new System.Windows.Forms.Padding(0);
            this.noteListDeleted.Name = "noteListDeleted";
            this.noteListDeleted.Size = new System.Drawing.Size(616, 497);
            this.noteListDeleted.TabIndex = 0;
            // 
            // TabAlarm
            // 
            this.TabAlarm.Controls.Add(this.tableLayoutPanel1);
            this.TabAlarm.Location = new System.Drawing.Point(4, 29);
            this.TabAlarm.Margin = new System.Windows.Forms.Padding(6);
            this.TabAlarm.Name = "TabAlarm";
            this.TabAlarm.Padding = new System.Windows.Forms.Padding(6);
            this.TabAlarm.Size = new System.Drawing.Size(639, 425);
            this.TabAlarm.TabIndex = 0;
            this.TabAlarm.Text = "Alarm";
            this.TabAlarm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCurrentTimeTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCurrentTime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSetAlarm, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(621, 407);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBox1, 2);
            this.checkBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(247, 328);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Active Alarm";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel5.Controls.Add(this.numericUpDownHour2);
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.numericUpDownMin2);
            this.flowLayoutPanel5.Controls.Add(this.label6);
            this.flowLayoutPanel5.Controls.Add(this.labelEdit2);
            this.flowLayoutPanel5.Controls.Add(this.labelLock2);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(282, 213);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(280, 35);
            this.flowLayoutPanel5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hour(s)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Minute(s)";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel4.Controls.Add(this.numericUpDownHour1);
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.numericUpDownMin1);
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.labelEdit1);
            this.flowLayoutPanel4.Controls.Add(this.labelLock1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(282, 147);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(280, 35);
            this.flowLayoutPanel4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hour(s)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minute(s)";
            // 
            // labelPostpone
            // 
            this.labelPostpone.AutoSize = true;
            this.labelPostpone.ForeColor = System.Drawing.Color.Red;
            this.labelPostpone.Location = new System.Drawing.Point(65, 0);
            this.labelPostpone.Margin = new System.Windows.Forms.Padding(0);
            this.labelPostpone.Name = "labelPostpone";
            this.labelPostpone.Size = new System.Drawing.Size(101, 20);
            this.labelPostpone.TabIndex = 10;
            this.labelPostpone.Text = "(Postponed)";
            // 
            // TabInfo
            // 
            this.TabInfo.Controls.Add(this.flowLayoutPanel2);
            this.TabInfo.Location = new System.Drawing.Point(4, 29);
            this.TabInfo.Margin = new System.Windows.Forms.Padding(6);
            this.TabInfo.Name = "TabInfo";
            this.TabInfo.Padding = new System.Windows.Forms.Padding(6);
            this.TabInfo.Size = new System.Drawing.Size(639, 425);
            this.TabInfo.TabIndex = 2;
            this.TabInfo.Text = "Info";
            this.TabInfo.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelVersion);
            this.flowLayoutPanel2.Controls.Add(this.labelVerVal);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(9, 9);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(354, 100);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(4, 4);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(3);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(74, 20);
            this.labelVersion.TabIndex = 7;
            this.labelVersion.Text = "Version: ";
            // 
            // labelVerVal
            // 
            this.labelVerVal.AutoSize = true;
            this.labelVerVal.Location = new System.Drawing.Point(84, 4);
            this.labelVerVal.Margin = new System.Windows.Forms.Padding(3);
            this.labelVerVal.MinimumSize = new System.Drawing.Size(150, 0);
            this.labelVerVal.Name = "labelVerVal";
            this.labelVerVal.Size = new System.Drawing.Size(150, 20);
            this.labelVerVal.TabIndex = 7;
            this.labelVerVal.Text = "Version Val(x.x.x.x)";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Alarm";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // testToolStripMenuItem
            // 
            //this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            //this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            //this.testToolStripMenuItem.Text = "test";
            //this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.propertyGrid1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(704, 64);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(567, 423);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Enabled = false;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(564, 417);
            this.propertyGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 498);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(535, 455);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyAlarmApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabNoteList.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.TabAlarm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin2)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.TabInfo.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSetAlarm;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Label labelCurrentTimeTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabAlarm;
        private System.Windows.Forms.TabPage TabInfo;
        //private System.Windows.Forms.Label LabelEntryTime;
        //private System.Windows.Forms.Label LabelLeaveTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelVerVal;
        private System.Windows.Forms.TabPage tabNoteList;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private Controls.NoteList noteListDraft;
        private Controls.NoteList noteListInProgress;
        private Controls.NoteList noteListDone;
        private Controls.NoteList noteListDeleted;
        //private System.Windows.Forms.Label LabelEarlyLeave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownHour1;
        private System.Windows.Forms.NumericUpDown numericUpDownMin1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.NumericUpDown numericUpDownHour2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownMin2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelEdit1;
        private System.Windows.Forms.Label labelLock1;
        private System.Windows.Forms.Label labelEdit2;
        private System.Windows.Forms.Label labelLock2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelPostpone;
    }
}

