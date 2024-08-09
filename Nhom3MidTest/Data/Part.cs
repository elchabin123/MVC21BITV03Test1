using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nhom3MidTest.Data;

public partial class Part
{
    
    [Required]
    public int Id { get; set; }
    

    [Display(Name="Tên thành phần")]
    [Required]
    
    public string Name { get; set; } = null!;

    
    [Display(Name = "Giá")]
    [Required]
    public double? Price { get; set; }

    [Display(Name = "Số Lượng")]
    [Required]
    public int Quantity { get; set; }

    [Display(Name = "Nhà Cung cấp")]
    [Required]
    public int SupplierId { get; set; }
    [Required]
    public virtual Supplier Supplier { get; set; } = null!;

    [Display(Name = "xe ô tô")]
    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
   
    
}
