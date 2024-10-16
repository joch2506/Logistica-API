using System;
using System.Collections.Generic;

namespace Logisitca.API.Data;

public partial class Product
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public decimal? UnitPrice { get; set; }
}
