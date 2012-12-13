namespace Timebox.UI
{
  partial class TimeboxEditor
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.chkStopTask = new System.Windows.Forms.CheckBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(206, 118);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 9;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(125, 118);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 8;
      this.btnOK.Text = "Activate";
      this.btnOK.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Duration:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(69, 10);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(211, 20);
      this.textBox1.TabIndex = 11;
      this.textBox1.Text = "60";
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
      // 
      // label2
      // 
      this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.label2.Location = new System.Drawing.Point(69, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(211, 19);
      this.label2.TabIndex = 12;
      this.label2.Text = "Enter minutes or hours, e.g. 1:30 or 90";
      this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Location = new System.Drawing.Point(69, 57);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(186, 17);
      this.checkBox1.TabIndex = 13;
      this.checkBox1.Text = "Alert me when the timebox expires";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // chkStopTask
      // 
      this.chkStopTask.AutoSize = true;
      this.chkStopTask.Checked = true;
      this.chkStopTask.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkStopTask.Location = new System.Drawing.Point(69, 80);
      this.chkStopTask.Name = "chkStopTask";
      this.chkStopTask.Size = new System.Drawing.Size(211, 17);
      this.chkStopTask.TabIndex = 14;
      this.chkStopTask.Text = "Stop the task when the timebox expires";
      this.chkStopTask.UseVisualStyleBackColor = true;
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // TimeboxEditor
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(297, 153);
      this.Controls.Add(this.chkStopTask);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "TimeboxEditor";
      this.ShowInTaskbar = false;
      this.Text = "Set Timebox";
      ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox chkStopTask;
    private System.Windows.Forms.ErrorProvider errorProvider1;
  }
}