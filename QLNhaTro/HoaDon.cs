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
    
    public partial class HoaDon
    {
        public int ID { get; set; }
        public Nullable<int> SoDien { get; set; }
        public Nullable<int> SoNuoc { get; set; }
        public decimal TongTien { get; set; }
        public int ThuePhongID { get; set; }
        public int ThangID { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
    
        public virtual Thang Thang { get; set; }
        public virtual ThuePhong ThuePhong { get; set; }
    }
}
