using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

public class InvoiceItem
{
    public string Locale { get; set; }
    public string Description { get; set; }
    public BoundingPoly BoundingPoly { get; set; }
}

public class BoundingPoly
{
    public List<Vertex> Vertices { get; set; }
}

public class Vertex
{
    public int X { get; set; }
    public int Y { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        // JSON dosyasını oku
        string jsonFilePath = @"C:\Users\Dell\Desktop\response.json"; 
        string jsonContent = File.ReadAllText(jsonFilePath);

        // JSON verisini C# nesnelerine dönüştür
        List<InvoiceItem> invoiceItems = JsonConvert.DeserializeObject<List<InvoiceItem>>(jsonContent);

        
        int lineCount = 1;
        foreach (var item in invoiceItems)
        {
            string[] lines = item.Description.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                Console.WriteLine($"{lineCount++} {line.Trim()}");
            }
        }
    }

}
