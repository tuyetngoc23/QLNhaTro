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
    
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            this.ThuePhongs = new HashSet<ThuePhong>();
        }
    
        public int ID { get; set; }
        public Nullable<int> SoPhong { get; set; }
        public Nullable<int> LoaiPhongID { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        public virtual LoaiPhong LoaiPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThuePhong> ThuePhongs { get; set; }
    }
}
