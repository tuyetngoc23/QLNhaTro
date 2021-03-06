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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBQLNhaTroEntities : DbContext
    {
        public DBQLNhaTroEntities()
            : base("name=DBQLNhaTroEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiPhi> ChiPhis { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<Thang> Thangs { get; set; }
        public virtual DbSet<ThuePhong> ThuePhongs { get; set; }
        public virtual DbSet<TraPhong> TraPhongs { get; set; }
    
        public virtual int sp_ThemKH(string tenKH, string cmnd, string queQuan, string gt, Nullable<System.DateTime> ngaySinh, string sdt, Nullable<int> id)
        {
            var tenKHParameter = tenKH != null ?
                new ObjectParameter("tenKH", tenKH) :
                new ObjectParameter("tenKH", typeof(string));
    
            var cmndParameter = cmnd != null ?
                new ObjectParameter("cmnd", cmnd) :
                new ObjectParameter("cmnd", typeof(string));
    
            var queQuanParameter = queQuan != null ?
                new ObjectParameter("queQuan", queQuan) :
                new ObjectParameter("queQuan", typeof(string));
    
            var gtParameter = gt != null ?
                new ObjectParameter("gt", gt) :
                new ObjectParameter("gt", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("ngaySinh", ngaySinh) :
                new ObjectParameter("ngaySinh", typeof(System.DateTime));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemKH", tenKHParameter, cmndParameter, queQuanParameter, gtParameter, ngaySinhParameter, sdtParameter, idParameter);
        }
    
        public virtual int sp_ThuePhong(Nullable<decimal> tienCoc, Nullable<System.DateTime> ngayNhanCoc, Nullable<int> phongID, Nullable<int> kHID)
        {
            var tienCocParameter = tienCoc.HasValue ?
                new ObjectParameter("tienCoc", tienCoc) :
                new ObjectParameter("tienCoc", typeof(decimal));
    
            var ngayNhanCocParameter = ngayNhanCoc.HasValue ?
                new ObjectParameter("ngayNhanCoc", ngayNhanCoc) :
                new ObjectParameter("ngayNhanCoc", typeof(System.DateTime));
    
            var phongIDParameter = phongID.HasValue ?
                new ObjectParameter("PhongID", phongID) :
                new ObjectParameter("PhongID", typeof(int));
    
            var kHIDParameter = kHID.HasValue ?
                new ObjectParameter("KHID", kHID) :
                new ObjectParameter("KHID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThuePhong", tienCocParameter, ngayNhanCocParameter, phongIDParameter, kHIDParameter);
        }
    
        public virtual int sp_TraPhong(Nullable<int> phongID, Nullable<int> kHID, Nullable<int> thuePhongID)
        {
            var phongIDParameter = phongID.HasValue ?
                new ObjectParameter("PhongID", phongID) :
                new ObjectParameter("PhongID", typeof(int));
    
            var kHIDParameter = kHID.HasValue ?
                new ObjectParameter("KHID", kHID) :
                new ObjectParameter("KHID", typeof(int));
    
            var thuePhongIDParameter = thuePhongID.HasValue ?
                new ObjectParameter("ThuePhongID", thuePhongID) :
                new ObjectParameter("ThuePhongID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_TraPhong", phongIDParameter, kHIDParameter, thuePhongIDParameter);
        }
    
        public virtual int sp_TinhTien(Nullable<int> maThue, Nullable<int> soDien, Nullable<int> soNuoc, Nullable<decimal> tongTien, Nullable<int> thangID)
        {
            var maThueParameter = maThue.HasValue ?
                new ObjectParameter("maThue", maThue) :
                new ObjectParameter("maThue", typeof(int));
    
            var soDienParameter = soDien.HasValue ?
                new ObjectParameter("soDien", soDien) :
                new ObjectParameter("soDien", typeof(int));
    
            var soNuocParameter = soNuoc.HasValue ?
                new ObjectParameter("soNuoc", soNuoc) :
                new ObjectParameter("soNuoc", typeof(int));
    
            var tongTienParameter = tongTien.HasValue ?
                new ObjectParameter("tongTien", tongTien) :
                new ObjectParameter("tongTien", typeof(decimal));
    
            var thangIDParameter = thangID.HasValue ?
                new ObjectParameter("thangID", thangID) :
                new ObjectParameter("thangID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_TinhTien", maThueParameter, soDienParameter, soNuocParameter, tongTienParameter, thangIDParameter);
        }
    }
}
