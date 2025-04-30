﻿namespace API.DTOs;

public class OrderItemDto
{
    public int ProductId { get; set; }
    public required string ProductName { get; set; }
    public required string Pictureurl { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}