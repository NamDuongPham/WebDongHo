
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LuxuryWatches.Data
{

using System;
    using System.Collections.Generic;
    
public partial class donHang
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public donHang()
    {

        this.chiTietDHs = new HashSet<chiTietDH>();

    }


    public int maDH { get; set; }

    public string tenKH { get; set; }

    public string soDT { get; set; }

    public string diaChi { get; set; }

    public string email { get; set; }

    public int tongSoLuong { get; set; }

    public int tongThanhTien { get; set; }

    public System.DateTime tdDatHang { get; set; }

    public bool daGiaoHang { get; set; }

    public Nullable<System.DateTime> tdGiaoHang { get; set; }

    public string ghiChu { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<chiTietDH> chiTietDHs { get; set; }

}

}
