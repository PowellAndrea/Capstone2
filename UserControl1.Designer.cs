namespace Metadata_Manager
{
   partial class UserControl1
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
         this.editingGrid1 = new Metadata_Manager.Models.EditingGrid();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.editingGrid1)).BeginInit();
         this.SuspendLayout();
         // 
         // editingGrid1
         // 
         this.editingGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.editingGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
         this.editingGrid1.Location = new System.Drawing.Point(46, 47);
         this.editingGrid1.Name = "editingGrid1";
         this.editingGrid1.RowTemplate.Height = 25;
         this.editingGrid1.Size = new System.Drawing.Size(466, 423);
         this.editingGrid1.TabIndex = 0;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "Column1";
         this.Column1.Name = "Column1";
         // 
         // UserControl1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.editingGrid1);
         this.Name = "UserControl1";
         this.Size = new System.Drawing.Size(574, 530);
         ((System.ComponentModel.ISupportInitialize)(this.editingGrid1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private Models.EditingGrid editingGrid1;
      private DataGridViewTextBoxColumn Column1;
   }
}
