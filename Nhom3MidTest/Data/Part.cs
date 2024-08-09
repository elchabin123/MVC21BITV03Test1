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
    [Required]
    public int Quantity { get; set; }
    [Required]
    public int SupplierId { get; set; }
    [Required]
    public virtual Supplier Supplier { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
   
    
}
