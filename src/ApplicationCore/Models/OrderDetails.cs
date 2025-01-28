using System.Collections.Generic;

namespace Microsoft.eShopWeb.ApplicationCore.Models;
public class OrderDetails
{
    public int OrderId { get; set; }
    public List<Item> Items { get; set; }
}
