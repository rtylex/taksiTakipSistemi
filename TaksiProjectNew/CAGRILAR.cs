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
    
    public partial class CAGRILAR
    {
        public int CAGRIID { get; set; }
        public Nullable<System.DateTime> TARİHSAAT { get; set; }
        public Nullable<int> MUSTERID { get; set; }
        public Nullable<int> ARACID { get; set; }
        public Nullable<int> SOFORID { get; set; }
        public string NOT { get; set; }
    
        public virtual ARACLAR ARACLAR { get; set; }
        public virtual MUSTERILER MUSTERILER { get; set; }
        public virtual SOFORLER SOFORLER { get; set; }
    }
}
