//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThongTinDangKy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinDangKy()
        {
            this.LichTaps = new HashSet<LichTap>();
        }
    
        public int MaDK { get; set; }
        public Nullable<int> MaCT { get; set; }
        public Nullable<int> MAHLV { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
        public Nullable<double> GiaTienDK { get; set; }
    
        public virtual ChiTietDichVu ChiTietDichVu { get; set; }
        public virtual HuanLuyenVien HuanLuyenVien { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichTap> LichTaps { get; set; }
    }
}
