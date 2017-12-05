using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string ImgPath { get; set; }
    public double Price { get; set; }
    public double MarkedDownPrice { get; set; }
    public string Description { get; set; }

    public Product()
    {
        ProductId = -1;
        ProductName = "";
        ImgPath = "";
        Price = 0.0;
        MarkedDownPrice = 0.0;
        Description = "";
    }
}