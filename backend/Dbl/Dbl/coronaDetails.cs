//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dbl
{
    using System;
    using System.Collections.Generic;
    
    public partial class coronaDetails
    {
        public int idMember { get; set; }
        public System.DateTime dateOfVaccination { get; set; }
        public string madeVaccination { get; set; }
        public Nullable<System.DateTime> dateTrue { get; set; }
        public Nullable<System.DateTime> dateRecovery { get; set; }
    
        public virtual Member Member { get; set; }
    }
}