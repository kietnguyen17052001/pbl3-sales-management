//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaleManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblNhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNhanVien()
        {
            this.tblHoaDonBanHangs = new HashSet<tblHoaDonBanHang>();
            this.tblHoaDonNhapHangs = new HashSet<tblHoaDonNhapHang>();
        }
    
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string ViTri { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Luong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHoaDonBanHang> tblHoaDonBanHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHoaDonNhapHang> tblHoaDonNhapHangs { get; set; }
    }
}
