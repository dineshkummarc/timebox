using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Timebox.Model;
using Timebox.UI;

namespace Timebox
{
  public partial class ReportControl : UserControl
  {
    public ReportControl()
    {
      InitializeComponent();
    }


    private void button1_Click(object sender, EventArgs e)
    {
      RefreshReport();
    }


    public void RefreshReport()
    { 
      lstEntries.Items.Clear();
      lstEntries.Groups.Clear();
      DateTime groupDate = DateTime.MinValue;
      ListViewGroup grpCurrent = null;
      StringBuilder sb = new StringBuilder();

      ProcessLogItemsSince(DefaultReportThreshold, entry =>
         {
           if (entry.StartedAt.Date != groupDate)
           {
             groupDate = entry.StartedAt.Date;
             grpCurrent = lstEntries.Groups.Add("grp" + entry.StartedAt.ToString(), entry.StartedAt.ToShortDateString());
           }

           var item = lstEntries.Items.Add(entry.Project);
           item.Group = grpCurrent;
           item.SubItems.Add(entry.StartedAt.AsHumanReadableTime());
           item.SubItems.Add(entry.Duration.AsHumanReadableDuration());
           item.SubItems.Add(entry.Comment);
           item.Tag = entry;
         });

      lstEntries_SelectedIndexChanged(this, EventArgs.Empty);
    }

    DateTime DefaultReportThreshold 
    { 
      get 
      {
        return Helpers.PreviousMonday();
      }
    }

    void ProcessLogItemsSince(DateTime when, Action<LogEntry> action)
    {
      var log = new TimeLog();
      var entries = log.GetEntriesSince(when);
      foreach (var entry in entries) action(entry);
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      var caption = "Reset database";
      var message = "Are you sure you want to clear all database entries?\r\nThis operation cannot be undone.";
      if(DialogResult.Yes != MessageBox.Show(message, 
        caption, 
        MessageBoxButtons.YesNo, 
        MessageBoxIcon.Warning, 
        MessageBoxDefaultButton.Button2))
        return;

      var log = new TimeLog();
      log.ResetDb();
      RefreshReport();
    }

    private void btnToClipboard_Click(object sender, EventArgs e)
    {
      StringBuilder sb = new StringBuilder(2000);
      DateTime groupDate = DateTime.MinValue;
      sb.AppendLine("Date         Project                   Start   Duration   Comment");
      ProcessLogItemsSince(DefaultReportThreshold, entry => {
        if(groupDate != entry.StartedAt.Date)
        {
          sb.AppendLine("----------------------------------------------------------------------------------");
          groupDate = entry.StartedAt.Date;
        }           
        
        sb.AppendFormat("{0,10}.  {1,-20}  {2, 9}  {3, 9}   {4}\r\n",
                    entry.StartedAt.ToShortDateString(),
                    entry.Project,
                    entry.StartedAt.AsHumanReadableTime(),
                    entry.Duration.AsHumanReadableDuration(),
                    entry.Comment);
      });

      Clipboard.SetText(sb.ToString());
    }

    private void btnToCSV_Click(object sender, EventArgs e)
    {

    }

    private void btnToHTML_Click(object sender, EventArgs e)
    {

    }

    private void cmdEdit_Click(object sender, EventArgs e)
    {
      var item = (LogEntry) lstEntries.SelectedItems[0].Tag;
      var frm = new EntryEditor(item);
      if(DialogResult.OK != frm.ShowDialog())
        return;

      ITimeLog log = new TimeLog();
      log.Update(item);
      RefreshReport();
    }

    private void cmdRemove_Click(object sender, EventArgs e)
    {
      var caption = "Delete entry";
      var message = "Are you sure you want to delete this log entry?\r\nThis operation cannot be undone.";
      if (DialogResult.Yes != MessageBox.Show(message,
        caption,
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button2))
        return;

      var item = (LogEntry) lstEntries.SelectedItems[0].Tag;
      ITimeLog log = new TimeLog();
      log.Remove(item);     
      RefreshReport();
    }

    private void lstEntries_SelectedIndexChanged(object sender, EventArgs e)
    {
      bool singleSelection = lstEntries.SelectedItems.Count == 1;
      cmdRemove.Enabled = singleSelection;
      cmdEdit.Enabled = singleSelection;
      cmdMerge.Enabled = false;
      if(lstEntries.SelectedItems.Count < 2) return;
      
      var items = lstEntries.SelectedItems.Cast<ListViewItem>().Select(i => (LogEntry)i.Tag);

      bool sameProject = items.GroupBy(i => i.Project).Count() == 1;
      if(!sameProject)
        return;

      var indices = lstEntries.SelectedItems.Cast<ListViewItem>().OrderBy(i => i.Index).Select(i => i.Index);
      bool continuousSelection = indices.Last() - indices.First() == indices.Count() - 1;
      cmdMerge.Enabled = continuousSelection;
    }

    private void cmdMerge_Click(object sender, EventArgs e)
    {
      var items = lstEntries.SelectedItems.Cast<ListViewItem>().Select(i => (LogEntry) i.Tag);
      var duration = items.Sum(i => i.Duration);
      var comments = items.Where(i => !string.IsNullOrEmpty(i.Comment)).Select(i => i.Comment).ToArray();
      string desc = string.Join(", ", comments);

      var itemList = items.ToList();
      var frm = new MergeForm(itemList, desc);
      if(DialogResult.OK != frm.ShowDialog()) return;

      desc = frm.Description;

      ITimeLog log = new TimeLog();
      log.Merge(itemList, desc);
      RefreshReport();
    }
  }
}
