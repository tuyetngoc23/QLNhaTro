//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNhaTro
{
    using System;
    using System.Collections.Generic;
    
    public partial class TraPhong
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public Nullable<int> ThuePhongID { get; set; }
        public Nullable<bool> TraCoc { get; set; }
    
        public virtual ThuePhong ThuePhong { get; set; }
    }
}