namespace Timebox.Model
{
  partial class EntryEditor
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtProject = new System.Windows.Forms.TextBox();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDuration = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Project:";
      // 
      // txtProject
      // 
      this.txtProject.Location = new System.Drawing.Point(70, 10);
      this.txtProject.Name = "txtProject";
      this.txtProject.Size = new System.Drawing.Size(173, 20);
      this.txtProject.TabIndex = 1;
      // 
      // txtComment
      // 
      this.txtComment.Location = new System.Drawing.Point(70, 36);
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(173, 20);
      this.txtComment.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Comment:";
      // 
      // txtDuration
      // 
      this.txtDuration.Location = new System.Drawing.Point(70, 62);
      this.txtDuration.Name = "txtDuration";
      this.txtDuration.Size = new System.Drawing.Size(173, 20);
      this.txtDuration.TabIndex = 5;
      this.txtDuration.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 65);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(50, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Duration:";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(87, 100);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 6;
      this.btnOK.Text = "Update";
      this.btnOK.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(168, 100);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // EntryEditor
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(256, 134);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.txtDuration);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtComment);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtProject);
      this.Controls.Add(this.label1);
      this.Name = "EntryEditor";
      this.Text = "Edit Log Entry";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtProject;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtDuration;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
  }
}