using System;
using System.Collections.Generic;

#nullable disable

namespace s4lab3.ScaffoldModel
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
