using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WorkingWithEFCore.AutoGen;

[Index("CategoryId", Name = "CategoriesProducts")]
[Index("CategoryId", Name = "CategoryId")]
[Index("ProductName", Name = "ProductName")]
[Index("SupplierId", Name = "SupplierId")]
[Index("SupplierId", Name = "SuppliersProducts")]
public partial class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [StringLength(40)]
    public string ProductName { get; set; } = null!;

    public int? SupplierId { get; set; }

    public int? CategoryId { get; set; }

    [StringLength(20)]
    public string? QuantityPerUnit { get; set; }

    [Column("UnitPrice", TypeName = "money")]
    public decimal? Cost { get; set; } // property name != column name

    [Column("UnitsInStock")]
    public short? Stock { get; set; }

    public short? UnitsOnOrder { get; set; }

    public short? ReorderLevel { get; set; }

    public bool Discontinued { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Products")]
    public virtual Category? Category { get; set; }
}
