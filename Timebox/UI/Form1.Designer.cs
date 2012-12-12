namespace Timebox
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.timerCtrl1 = new Timebox.TimerCtrl();
      this.reportControl1 = new Timebox.ReportControl();
      this.statsControl1 = new Timebox.StatsControl();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(326, 176);
      this.tabControl1.TabIndex = 0;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.Color.Transparent;
      this.tabPage1.Controls.Add(this.timerCtrl1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(318, 150);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Timer";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
      this.tabPage2.Controls.Add(this.reportControl1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(318, 150);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "History";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // tabPage3
      // 
      this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
      this.tabPage3.Controls.Add(this.statsControl1);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(318, 150);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Statistics";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // timerCtrl1
      // 
      this.timerCtrl1.BackColor = System.Drawing.Color.Transparent;
      this.timerCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.timerCtrl1.Location = new System.Drawing.Point(3, 3);
      this.timerCtrl1.Name = "timerCtrl1";
      this.timerCtrl1.Size = new System.Drawing.Size(312, 144);
      this.timerCtrl1.TabIndex = 0;
      // 
      // reportControl1
      // 
      this.reportControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.reportControl1.Location = new System.Drawing.Point(3, 3);
      this.reportControl1.Name = "reportControl1";
      this.reportControl1.Size = new System.Drawing.Size(312, 144);
      this.reportControl1.TabIndex = 0;
      // 
      // statsControl1
      // 
      this.statsControl1.BackColor = System.Drawing.SystemColors.Control;
      this.statsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.statsControl1.Location = new System.Drawing.Point(0, 0);
      this.statsControl1.Name = "statsControl1";
      this.statsControl1.Size = new System.Drawing.Size(318, 150);
      this.statsControl1.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(326, 176);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.Text = "Timebox";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private TimerCtrl timerCtrl1;
    private ReportControl reportControl1;
    private System.Windows.Forms.TabPage tabPage3;
    private StatsControl statsControl1;
  }
}

