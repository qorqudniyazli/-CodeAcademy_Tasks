﻿namespace OOP.Inheritance.Models;

public class Category : BaseAuditableEntity
{
    public string CategoryName { get; set; } = null!;
    public string? Description { get; set; }
}
