﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entities;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int Price { get; set; }

    public int CategoryId { get; set; }

    public string? Description { get; set; }

    public string ImageUrl { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;
/*    [JsonIgnore]
*/    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
