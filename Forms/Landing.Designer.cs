namespace Metadata_Manager.Forms
{
   partial class Landing
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openPdfFile = new System.Windows.Forms.OpenFileDialog();
            this.dataGridMain = new Metadata_Manager.Models.EditingGrid();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearPublished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "Main Menu";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpenPdf,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "File";
            // 
            // menuItemOpenPdf
            // 
            this.menuItemOpenPdf.Name = "menuItemOpenPdf";
            this.menuItemOpenPdf.Size = new System.Drawing.Size(137, 22);
            this.menuItemOpenPdf.Text = "Open pdf(s)";
            this.menuItemOpenPdf.Click += new System.EventHandler(this.openPdfsToolStripMenuItem_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(137, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // openPdfFile
            // 
            this.openPdfFile.DefaultExt = "pdf";
            this.openPdfFile.Filter = "Pdf files | *.pdf";
            this.openPdfFile.Multiselect = true;
            this.openPdfFile.Title = "Open Files";
            // 
            // dataGridMain
            // 
            this.dataGridMain.AllowUserToAddRows = false;
            this.dataGridMain.AllowUserToDeleteRows = false;
            this.dataGridMain.AllowUserToOrderColumns = true;
            this.dataGridMain.AllowUserToResizeRows = false;
            this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Details,
            this.FileName,
            this.RecordTitle,
            this.Author,
            this.YearPublished,
            this.RecordSeries,
            this.FilePath});
            this.dataGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridMain.Location = new System.Drawing.Point(0, 24);
            this.dataGridMain.Name = "dataGridMain";
            this.dataGridMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridMain.RowTemplate.Height = 25;
            this.dataGridMain.Size = new System.Drawing.Size(800, 426);
            this.dataGridMain.TabIndex = 5;
            this.dataGridMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMain_CellClick);
            this.dataGridMain.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridMain_RowValidating);
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Details.Frozen = true;
            this.Details.HeaderText = "...";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Details.Width = 22;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileName.DataPropertyName = "FileName";
            this.FileName.Frozen = true;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FileName.Width = 66;
            // 
            // RecordTitle
            // 
            this.RecordTitle.DataPropertyName = "Title";
            this.RecordTitle.HeaderText = "Title";
            this.RecordTitle.Name = "RecordTitle";
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author(s)";
            this.Author.Name = "Author";
            // 
            // YearPublished
            // 
            this.YearPublished.HeaderText = "Published";
            this.YearPublished.Name = "YearPublished";
            // 
            // RecordSeries
            // 
            this.RecordSeries.HeaderText = "Record Series";
            this.RecordSeries.Name = "RecordSeries";
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "Path";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Width = 692;
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridMain);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Landing";
            this.Text = "Landing";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private MenuStrip menuMain;
      private ToolStripMenuItem menuItemFile;
      private ToolStripMenuItem menuItemOpenPdf;
      private ToolStripMenuItem menuItemExit;
      private OpenFileDialog openPdfFile;
      private Models.EditingGrid dataGridMain;
        private DataGridViewButtonColumn Details;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn RecordTitle;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn YearPublished;
        private DataGridViewTextBoxColumn RecordSeries;
        private DataGridViewTextBoxColumn FilePath;
    }
}