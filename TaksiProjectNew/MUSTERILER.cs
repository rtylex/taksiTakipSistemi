//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaksiProjectNew
{
    using System;
    using System.Collections.Generic;
    
    public partial class MUSTERILER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MUSTERILER()
        {
            this.CAGRILAR = new HashSet<CAGRILAR>();
        }
    
        public int MUSTERIID { get; set; }
        public string ADISOYADI { get; set; }
        public string ADRES { get; set; }
        public string ADRESTARİF { get; set; }
        public string TELEFON { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAGRILAR> CAGRILAR { get; set; }
    }
}
