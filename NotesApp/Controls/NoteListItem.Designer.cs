using System;
using System.Windows.Forms;

namespace NotesApp.Controls
{
    partial class NoteListItem
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

        #region 元件設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabelEdit = new System.Windows.Forms.LinkLabel();
            this.linkLabelStart = new System.Windows.Forms.LinkLabel();
            this.linkLabelDone = new System.Windows.Forms.LinkLabel();
            this.linkLabelReturn = new System.Windows.Forms.LinkLabel();
            this.linkLabelDelete = new System.Windows.Forms.LinkLabel();
            this.linkLabelRestore = new System.Windows.Forms.LinkLabel();
            this.linkLabelClear = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 24);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(14, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 63);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(31, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(78, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject xxxx Subject xxxx Subject xxxx Subject xxxx Subject xxxx Subject xxxx Sub" +
    "ject xxxx ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.linkLabelEdit);
            this.flowLayoutPanel1.Controls.Add(this.linkLabelStart);
            this.flowLayoutPanel1.Controls.Add(this.linkLabelDone);
            this.flowLayoutPanel1.Controls.Add(this.linkLabelReturn);
            this.flowLayoutPanel1.Controls.Add(this.linkLabelDelete);
            this.flowLayoutPanel1.Controls.Add(this.linkLabelRestore);
            this.flowLayoutPanel1.Controls.Add(this.linkLabelClear);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(418, 9);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 8, 0, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(176, 43);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // linkLabelEdit
            // 
            this.linkLabelEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelEdit.AutoSize = true;
            this.linkLabelEdit.Location = new System.Drawing.Point(0, 15);
            this.linkLabelEdit.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.linkLabelEdit.Name = "linkLabelEdit";
            this.linkLabelEdit.Size = new System.Drawing.Size(38, 20);
            this.linkLabelEdit.TabIndex = 2;
            this.linkLabelEdit.TabStop = true;
            this.linkLabelEdit.Text = "Edit";
            this.linkLabelEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEdit_LinkClicked);
            // 
            // linkLabelStart
            // 
            this.linkLabelStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelStart.AutoSize = true;
            this.linkLabelStart.Location = new System.Drawing.Point(48, 15);
            this.linkLabelStart.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.linkLabelStart.Name = "linkLabelStart";
            this.linkLabelStart.Size = new System.Drawing.Size(45, 20);
            this.linkLabelStart.TabIndex = 3;
            this.linkLabelStart.TabStop = true;
            this.linkLabelStart.Text = "Start";
            this.linkLabelStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelStart_LinkClicked);
            // 
            // linkLabelDone
            // 
            this.linkLabelDone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelDone.AutoSize = true;
            this.linkLabelDone.Location = new System.Drawing.Point(103, 15);
            this.linkLabelDone.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.linkLabelDone.Name = "linkLabelDone";
            this.linkLabelDone.Size = new System.Drawing.Size(50, 20);
            this.linkLabelDone.TabIndex = 4;
            this.linkLabelDone.TabStop = true;
            this.linkLabelDone.Text = "Done";
            this.linkLabelDone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDone_LinkClicked);
            // 
            // linkLabelReturn
            // 
            this.linkLabelReturn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelReturn.AutoSize = true;
            this.linkLabelReturn.Location = new System.Drawing.Point(0, 65);
            this.linkLabelReturn.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.linkLabelReturn.Name = "linkLabelReturn";
            this.linkLabelReturn.Size = new System.Drawing.Size(60, 20);
            this.linkLabelReturn.TabIndex = 5;
            this.linkLabelReturn.TabStop = true;
            this.linkLabelReturn.Text = "Return";
            this.linkLabelReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReturn_LinkClicked);
            // 
            // linkLabelDelete
            // 
            this.linkLabelDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelDelete.AutoSize = true;
            this.linkLabelDelete.Location = new System.Drawing.Point(70, 65);
            this.linkLabelDelete.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.linkLabelDelete.Name = "linkLabelDelete";
            this.linkLabelDelete.Size = new System.Drawing.Size(58, 20);
            this.linkLabelDelete.TabIndex = 6;
            this.linkLabelDelete.TabStop = true;
            this.linkLabelDelete.Text = "Delete";
            this.linkLabelDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDelete_LinkClicked);
            // 
            // linkLabelRestore
            // 
            this.linkLabelRestore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelRestore.AutoSize = true;
            this.linkLabelRestore.Location = new System.Drawing.Point(0, 115);
            this.linkLabelRestore.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.linkLabelRestore.Name = "linkLabelRestore";
            this.linkLabelRestore.Size = new System.Drawing.Size(66, 20);
            this.linkLabelRestore.TabIndex = 7;
            this.linkLabelRestore.TabStop = true;
            this.linkLabelRestore.Text = "Restore";
            this.linkLabelRestore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRestore_LinkClicked);
            // 
            // linkLabelClear
            // 
            this.linkLabelClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelClear.AutoSize = true;
            this.linkLabelClear.Location = new System.Drawing.Point(76, 115);
            this.linkLabelClear.Margin = new System.Windows.Forms.Padding(0, 15, 10, 15);
            this.linkLabelClear.Name = "linkLabelClear";
            this.linkLabelClear.Size = new System.Drawing.Size(48, 20);
            this.linkLabelClear.TabIndex = 8;
            this.linkLabelClear.TabStop = true;
            this.linkLabelClear.Text = "Clear";
            this.linkLabelClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClear_LinkClicked);
            // 
            // NoteListItem
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NoteListItem";
            this.Size = new System.Drawing.Size(599, 63);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabelEdit;
        private System.Windows.Forms.LinkLabel linkLabelStart;
        private System.Windows.Forms.LinkLabel linkLabelDone;
        private System.Windows.Forms.LinkLabel linkLabelReturn;
        private System.Windows.Forms.LinkLabel linkLabelDelete;
        private System.Windows.Forms.LinkLabel linkLabelRestore;
        private System.Windows.Forms.LinkLabel linkLabelClear;
    }
}
