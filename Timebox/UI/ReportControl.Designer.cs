namespace Timebox
{
  partial class ReportControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.btnToClipboard = new System.Windows.Forms.Button();
      this.btnToCSV = new System.Windows.Forms.Button();
      this.btnToHTML = new System.Windows.Forms.Button();
      this.lstEntries = new System.Windows.Forms.ListView();
      this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
      this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
      this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
      this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cmdEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.cmdRemove = new System.Windows.Forms.ToolStripMenuItem();
      this.btnReset = new System.Windows.Forms.Button();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.cmdMerge = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnToClipboard
      // 
      this.btnToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnToClipboard.Location = new System.Drawing.Point(3, 328);
      this.btnToClipboard.Name = "btnToClipboard";
      this.btnToClipboard.Size = new System.Drawing.Size(90, 31);
      this.btnToClipboard.TabIndex = 2;
      this.btnToClipboard.Text = "To Clipboard";
      this.btnToClipboard.UseVisualStyleBackColor = true;
      this.btnToClipboard.Click += new System.EventHandler(this.btnToClipboard_Click);
      // 
      // btnToCSV
      // 
      this.btnToCSV.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnToCSV.Enabled = false;
      this.btnToCSV.Location = new System.Drawing.Point(99, 328);
      this.btnToCSV.Name = "btnToCSV";
      this.btnToCSV.Size = new System.Drawing.Size(90, 31);
      this.btnToCSV.TabIndex = 3;
      this.btnToCSV.Text = "To CSV";
      this.btnToCSV.UseVisualStyleBackColor = true;
      this.btnToCSV.Click += new System.EventHandler(this.btnToCSV_Click);
      // 
      // btnToHTML
      // 
      this.btnToHTML.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnToHTML.Enabled = false;
      this.btnToHTML.Location = new System.Drawing.Point(195, 328);
      this.btnToHTML.Name = "btnToHTML";
      this.btnToHTML.Size = new System.Drawing.Size(90, 31);
      this.btnToHTML.TabIndex = 4;
      this.btnToHTML.Text = "To HTML";
      this.btnToHTML.UseVisualStyleBackColor = true;
      this.btnToHTML.Click += new System.EventHandler(this.btnToHTML_Click);
      // 
      // lstEntries
      // 
      this.lstEntries.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lstEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
      this.lstEntries.ContextMenuStrip = this.contextMenuStrip1;
      this.lstEntries.FullRowSelect = true;
      this.lstEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.lstEntries.Location = new System.Drawing.Point(3, 0);
      this.lstEntries.Name = "lstEntries";
      this.lstEntries.Size = new System.Drawing.Size(475, 322);
      this.lstEntries.TabIndex = 5;
      this.lstEntries.UseCompatibleStateImageBehavior = false;
      this.lstEntries.View = System.Windows.Forms.View.Details;
      this.lstEntries.SelectedIndexChanged += new System.EventHandler(this.lstEntries_SelectedIndexChanged);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Project";
      this.columnHeader1.Width = 94;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Started At";
      this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.columnHeader4.Width = 65;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Duration";
      this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.columnHeader2.Width = 61;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Comment";
      this.columnHeader3.Width = 223;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdEdit,
            this.cmdRemove,
            this.toolStripSeparator1,
            this.cmdMerge});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(161, 98);
      // 
      // cmdEdit
      // 
      this.cmdEdit.Name = "cmdEdit";
      this.cmdEdit.Size = new System.Drawing.Size(160, 22);
      this.cmdEdit.Text = "Edit Log Entry";
      this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
      // 
      // cmdRemove
      // 
      this.cmdRemove.Name = "cmdRemove";
      this.cmdRemove.Size = new System.Drawing.Size(160, 22);
      this.cmdRemove.Text = "Delete Log Entry";
      this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
      // 
      // btnReset
      // 
      this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnReset.Location = new System.Drawing.Point(291, 328);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(90, 31);
      this.btnReset.TabIndex = 6;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
      // 
      // cmdMerge
      // 
      this.cmdMerge.Enabled = false;
      this.cmdMerge.Name = "cmdMerge";
      this.cmdMerge.Size = new System.Drawing.Size(160, 22);
      this.cmdMerge.Text = "Merge Entries";
      this.cmdMerge.Click += new System.EventHandler(this.cmdMerge_Click);
      // 
      // ReportControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lstEntries);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnToClipboard);
      this.Controls.Add(this.btnToHTML);
      this.Controls.Add(this.btnToCSV);
      this.Name = "ReportControl";
      this.Size = new System.Drawing.Size(481, 362);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnToClipboard;
    private System.Windows.Forms.Button btnToCSV;
    private System.Windows.Forms.Button btnToHTML;
    private System.Windows.Forms.ListView lstEntries;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem cmdEdit;
    private System.Windows.Forms.ToolStripMenuItem cmdRemove;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem cmdMerge;
  }
}
