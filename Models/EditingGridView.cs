using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata_Manager.Models
{
   public class EditingGridView : DataGridView
   {


      // implemented as a singleton
      public Lazy<EditingGridView> lazy = 
         new Lazy<EditingGridView>(() => new EditingGridView());

      public EditingGridView Instance { get { return lazy.Value; } }


      public EditingGridView() {
         ///  Update to manually create EditingGrid rather than use designer
         ///SetAllHeaders();
      }
   }
}
// Use fields from the Record object to generate table, instead of addig to .net generated columns.
// File Name | Title | Year Published | Start Year | End Year| Author | Record Series | File Path
