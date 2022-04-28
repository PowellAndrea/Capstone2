/* Andrea Powell, Spring 2022
 * Capstone project
 * 
 * ToDo:
 *    Use fields from the Record object to generate data grid, instead of addig to .net generated columns.
 *    
 *    Think about pdfDocumentID and pdfInstanceID.  Do I want to search for other instances of the same document?  
 *    Is the new destiation document a different documentID?
 * 
 * *** Multi-Select changes not yet working
 * *** Add validation back or new info is never written?
 * 
 * Define here or in class?  Will be null until the new pdfDocument object is instanciated. 
 *    PdfWriter destinationWriter;
 *    PdfReader sourceReader;
 * 
 *    Look at itext7 GetXmpMetadata(bool createNew)
 *    
 *    Set font if dirty & update when written
 *    Don't update again on exit unless there are changes
 *    Where is my pencil for editing?
 *    Grey out read-only fields
 */

using iText.Kernel.Pdf;
using iText.Kernel.XMP;
using Metadata_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metadata_Manager.Forms
{
   public partial class Landing : Form
   {
      private PdfRecord Record;

      public Landing()
      {
         InitializeComponent();
      }

      private void openPdfsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         PdfDocument sourceDocument;
         PdfDocumentInfo sourceInfo;

         dataGridMain.Rows.Clear();

          if (openPdfFile.ShowDialog() == DialogResult.OK)
          {
            Record = new PdfRecord();
            int count = 0;


            foreach (string File in openPdfFile.FileNames)
            {
               // Open Dialog filters out non-PDF files

               Record.FilePath = openPdfFile.FileNames[count];
               Record.FileName = openPdfFile.SafeFileNames[count];

               // fix to use a single reader?
               // move all this stuff to PdfRecordClass
               sourceDocument = new PdfDocument(new PdfReader(Record.FilePath));
               sourceInfo = sourceDocument.GetDocumentInfo();

               Record.Title = sourceInfo.GetTitle();
               Record.Author = sourceInfo.GetAuthor();
               Record.Published = sourceInfo.GetMoreInfo("Published");
               Record.RecordSeries = sourceInfo.GetMoreInfo("RecordSeries");
               
               //Record.ShowPdfInBrowser(Record.FilePath);

               dataGridMain.Rows.Add("URL", Record.FileName, Record.Title, Record.Author, Record.Published, Record.RecordSeries, Record.FilePath);
               sourceDocument.Close();
               count++;
            
            }
// Fix this for Dynamic Path
// This works - need to add to grid after load from Record is working
//Record.ShowPdfInBrowser(Record.FileName);
          dataGridMain.Refresh();
          dataGridMain.Show();
         }
      }  


      private void menuItemExit_Click(object sender, EventArgs e)
      {
         // Need to add verification step to make sure all changes have been saved.
         Close();
      }

      //      // May want to call a Record.Validating function in class instead.
      //      // This is firing again when the program is closed - fix the event triggers
      private void dataGridMain_RowValidating(object sender, DataGridViewCellCancelEventArgs e) { }

      private void dataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         if (e.ColumnIndex == 0) {
            string _filePath = dataGridMain.Rows[e.RowIndex].Cells[6].Value.ToString();

            Record.ShowPdfInBrowser(_filePath); }
      }

      // Nothing Actually Happening to Update (removed for testing)
   }
}
