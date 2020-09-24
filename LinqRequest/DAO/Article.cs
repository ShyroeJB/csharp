namespace DAO
{
    public class Article
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Article(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString() => $"Name : {Name}, Price : {Price}, Quantity : {Quantity}";
    }
}
