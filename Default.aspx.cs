using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Storefront : System.Web.UI.Page
{
    private List<Product> CreateProductListFromStrings(List<string> FileLines)
    {
        List<Product> Result = new List<Product>();

        List<string> Header = FileLines[0].Split(';').ToList<string>();
        for (int i = 1; i < FileLines.Count ; i++)
        {
            List<string> Values = FileLines[i].Split(';').ToList<string>();

            Product TempProd = new Product();
            TempProd.ProductId = int.Parse(Values[Header.IndexOf("id")]);
            TempProd.ProductName = Values[Header.IndexOf("productname")];
            TempProd.ImgPath = Values[Header.IndexOf("imagename")];
            TempProd.MarkedDownPrice = double.Parse(Values[Header.IndexOf("specialOffer")]);
            TempProd.Price = double.Parse(Values[Header.IndexOf("normalPrice")]);
            TempProd.Description = Values[Header.IndexOf("description")];
            Result.Add(TempProd);
        }

        return Result;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string fileName = "..\\assets\\products.csv";
            string appDir = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            string path = Path.Combine(appDir, fileName);

            List<string> FileLines = File.ReadAllLines(path).ToList<string>();
            List<Product> ProductList =  CreateProductListFromStrings(FileLines);
        }
    }
}