using NuGet.DependencyResolver;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nhom3MidTest.Data;

public partial class Customer
{
    [Required]
    public int Id { get; set; }
    [MinLength(1)]
    public string Name { get; set; } = null!;
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }

    public bool IsYoungDriver { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
