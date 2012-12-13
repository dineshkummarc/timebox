namespace Timebox
{
  partial class TimerCtrl
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerCtrl));
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cmdSetTimebox = new System.Windows.Forms.ToolStripMenuItem();
      this.cmdRemoveTimebox = new System.Windows.Forms.ToolStripMenuItem();
      this.cmdToggleFrame = new System.Windows.Forms.ToolStripMenuItem();
      this.cboProjects = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.button1 = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.lblTime = new Timebox.TimeLabel();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdSetTimebox,
            this.cmdRemoveTimebox,
            this.cmdToggleFrame});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(167, 70);
      // 
      // cmdSetTimebox
      // 
      this.cmdSetTimebox.Name = "cmdSetTimebox";
      this.cmdSetTimebox.Size = new System.Drawing.Size(166, 22);
      this.cmdSetTimebox.Text = "Set Timebox...";
      this.cmdSetTimebox.Visible = false;
      this.cmdSetTimebox.Click += new System.EventHandler(this.cmdSetTimebox_Click);
      // 
      // cmdRemoveTimebox
      // 
      this.cmdRemoveTimebox.Name = "cmdRemoveTimebox";
      this.cmdRemoveTimebox.Size = new System.Drawing.Size(166, 22);
      this.cmdRemoveTimebox.Text = "Remove Timebox";
      this.cmdRemoveTimebox.Visible = false;
      this.cmdRemoveTimebox.Click += new System.EventHandler(this.cmdRemoveTimebox_Click);
      // 
      // cmdToggleFrame
      // 
      this.cmdToggleFrame.Name = "cmdToggleFrame";
      this.cmdToggleFrame.Size = new System.Drawing.Size(166, 22);
      this.cmdToggleFrame.Text = "Toggle Frame";
      // 
      // cboProjects
      // 
      this.cboProjects.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cboProjects.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cboProjects.FormattingEnabled = true;
      this.cboProjects.Location = new System.Drawing.Point(59, 89);
      this.cboProjects.Name = "cboProjects";
      this.cboProjects.Size = new System.Drawing.Size(245, 21);
      this.cboProjects.TabIndex = 0;
      this.cboProjects.TextChanged += new System.EventHandler(this.cboProjects_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(-3, 92);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Project:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(-3, 119);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Comment:";
      // 
      // txtComment
      // 
      this.txtComment.Location = new System.Drawing.Point(59, 116);
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(245, 20);
      this.txtComment.TabIndex = 1;
      // 
      // timer1
      // 
      this.timer1.Interval = 200;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // button1
      // 
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.ImageIndex = 2;
      this.button1.ImageList = this.imageList1;
      this.button1.Location = new System.Drawing.Point(240, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(64, 64);
      this.button1.TabIndex = 2;
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "1355219918_start.png");
      this.imageList1.Images.SetKeyName(1, "1355219976_stop-red.png");
      this.imageList1.Images.SetKeyName(2, "1355220707_paly.png");
      this.imageList1.Images.SetKeyName(3, "1355220700_stop.png");
      // 
      // lblTime
      // 
      this.lblTime.BackColor = System.Drawing.Color.MistyRose;
      this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblTime.ContextMenuStrip = this.contextMenuStrip1;
      this.lblTime.Elapsed = 0;
      this.lblTime.Font = new System.Drawing.Font("Calibri", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.lblTime.Location = new System.Drawing.Point(0, 12);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(236, 64);
      this.lblTime.TabIndex = 3;
      this.lblTime.Text = "0:00:00";
      this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblTime.DoubleClick += new System.EventHandler(this.lblTime_DoubleClick);
      // 
      // TimerCtrl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Transparent;
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtComment);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cboProjects);
      this.Controls.Add(this.lblTime);
      this.Name = "TimerCtrl";
      this.Size = new System.Drawing.Size(315, 145);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TimeLabel lblTime;
    private System.Windows.Forms.ComboBox cboProjects;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem cmdSetTimebox;
    private System.Windows.Forms.ToolStripMenuItem cmdRemoveTimebox;
    private System.Windows.Forms.ToolStripMenuItem cmdToggleFrame;
  }
}
