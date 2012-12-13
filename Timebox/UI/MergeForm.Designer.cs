namespace Timebox.UI
{
  partial class MergeForm
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
      this.txtComment = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtComment
      // 
      this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtComment.Location = new System.Drawing.Point(73, 46);
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(247, 20);
      this.txtComment.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Comment:";
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(245, 82);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 9;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(164, 82);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 8;
      this.btnOK.Text = "Merge";
      this.btnOK.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.Location = new System.Drawing.Point(3, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(317, 36);
      this.label3.TabIndex = 10;
      this.label3.Text = "Selected entries will be merged.  You can specify the description.";
      // 
      // MergeForm
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(332, 117);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.txtComment);
      this.Controls.Add(this.label2);
      this.MaximumSize = new System.Drawing.Size(800, 155);
      this.MinimumSize = new System.Drawing.Size(300, 155);
      this.Name = "MergeForm";
      this.ShowInTaskbar = false;
      this.Text = "MergeForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label label3;
  }
}