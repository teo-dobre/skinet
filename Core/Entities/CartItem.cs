﻿namespace Core.Entities;

public class CartItem
{
    public int ProductId { get; set; }
    public required string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public required string pictureUrl { get; set; }
    public required string Brand { get; set; }
    public required string Type { get; set; }
}
