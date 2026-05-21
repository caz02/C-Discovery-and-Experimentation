public class CartManager
{
    // A senior might ask you: "What happens if 'items' is null?"
    public double CalculateTotal(double[] items, bool isGoldMember)
    {
        double total = 0;
        if (items == null || items.Length == 0)
        {
            return -1; // error code for empty or null arguments
        }

        for (int i = 0; i < items.Length; i++)
        {
            double price = items[i];

            // Rule 1: No item should ever be free or negative
            if (price <= 0)
            {
                continue; // Skip it and move to the next item
            }

            // Rule 2: If an item is over $100, give a 10% "Bulk Item" discount
            if (price >= 100)
            {
                price = price * 0.90; 
            }

            total = total + price;
        }

        // Rule 3: Gold members get $5 off the final total
        // BUG ALERT: What if the total is only $3? 
        if (isGoldMember)
        
        {

            total = total - 5;
        }
          if (total < 0) { total = 0; }

        return total;
    }
}