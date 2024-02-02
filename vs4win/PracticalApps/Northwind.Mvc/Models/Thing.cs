namespace Northwind.Mvc.Models;
using System.ComponentModel.DataAnnotations;

public record Thing(
    [Range(1, 10)] int? Id,
    [Required] string? Color,
    [EmailAddress] string? Email
);