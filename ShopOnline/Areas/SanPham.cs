//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopOnline.Areas
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.CTHoaDons = new HashSet<CTHoaDon>();
            this.NhanXets = new HashSet<NhanXet>();
        }
    
        public int ID_SP { get; set; }
        public string TenSP { get; set; }
        public string GiaBan { get; set; }
        public string MoTa { get; set; }
        public string SoLuongTon { get; set; }
        public string SoLuongBan { get; set; }
        public string TinhTrangSP { get; set; }
        public Nullable<int> ID_LoaiSP { get; set; }
        public Nullable<int> ID_NhaSanXuat { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public string HinhAnhSP { get; set; }
        public Nullable<int> ID_User { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHoaDon> CTHoaDons { get; set; }
        public virtual LoaiSP LoaiSP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanXet> NhanXets { get; set; }
        public virtual NhaSanXuat NhaSanXuat { get; set; }
        public virtual UserAdmin UserAdmin { get; set; }
    }
}
