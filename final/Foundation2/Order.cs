using System;


// 
public class Order
{
    private List<string> shoppingList = new List<string>();

    private string filename = "shoppinglist.txt";

    public void addProduct(string product)
    {
        shoppingList.Add(product);
    }

    public void saveShoppingList()
    {
        using (StreamWriter w = new StreamWriter(filename))
        {
            foreach(string item in shoppingList)
            {
                w.WriteLine(item);
            }
        }
    }

    public void packingOrder()
    {
        foreach (String product in shoppingList)
        {
            Console.WriteLine(product);
        }
    }

    public int getItemPrices()
    {
        string[] lines = File.ReadAllLines(filename);
        int totalOrderPrice = 0;
        foreach (string line in lines)
        {
            string[] col = line.Split(",");
            
            int price = int.Parse(col[2]);
            int quantity = int.Parse(col[3]);
            int totalPrice = price * quantity;

            totalOrderPrice += totalPrice;
        }
        return totalOrderPrice;
    }

    public void printOrder()
    {
        foreach(string line in shoppingList)
        {
            Console.WriteLine(line);
        }
    }


}