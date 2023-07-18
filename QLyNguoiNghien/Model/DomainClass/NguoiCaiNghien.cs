using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QLyNguoiNghien.DomainClass;

[Table("NguoiCaiNghien")]
public partial class NguoiCaiNghien
{
    [Key]
    [Column("guidID")]
    public Guid GuidId { get; set; }

    [Column("maNghien")]
    [StringLength(7)]
    public string? MaNghien { get; set; }

    [Column("hoTen")]
    [StringLength(50)]
    public string? HoTen { get; set; }

    [Column("tuoi")]
    public int? Tuoi { get; set; }

    [Column("diaChi")]
    [StringLength(50)]
    public string? DiaChi { get; set; }

    [Column("loaiThuoc")]
    [StringLength(50)]
    public string? LoaiThuoc { get; set; }

    [Column("phuongPhap")]
    [StringLength(50)]
    public string? PhuongPhap { get; set; }
}
