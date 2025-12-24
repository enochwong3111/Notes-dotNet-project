namespace NotesApp.Controls
{
    partial class NoteList
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public string DeleteLableText
        {
            get
            {
                return this.listSearch.DeleteLableText;
            }
            set
            {
                this.listSearch.DeleteLableText = value;
            }

        }

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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelNoteList = new System.Windows.Forms.FlowLayoutPanel();
            this.listSearch = new NotesApp.Controls.NoteListSearch();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelNoteList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listSearch, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanelNoteList
            // 
            this.flowLayoutPanelNoteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelNoteList.AutoScroll = true;
            this.flowLayoutPanelNoteList.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanelNoteList.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelNoteList.Name = "flowLayoutPanelNoteList";
            this.flowLayoutPanelNoteList.Size = new System.Drawing.Size(599, 415);
            this.flowLayoutPanelNoteList.TabIndex = 16;
            // 
            // listSearch
            // 
            this.listSearch.DeleteLableText = "Delete";
            this.listSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.listSearch.Location = new System.Drawing.Point(0, 0);
            this.listSearch.Margin = new System.Windows.Forms.Padding(0);
            this.listSearch.Name = "listSearch";
            this.listSearch.NoteList = null;
            this.listSearch.Size = new System.Drawing.Size(599, 50);
            this.listSearch.TabIndex = 15;
            // 
            // NoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NoteList";
            this.Size = new System.Drawing.Size(599, 465);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private NoteListSearch listSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNoteList;
    }
}
