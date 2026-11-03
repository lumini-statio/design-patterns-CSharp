namespace decorator;

public class Cafe
{
    private Queue<Coffee> _orders;
    public Cafe()
    {
        _orders = new();
    }
    public double MakeOrder(Coffee coffee)
    {
        _orders.Enqueue(coffee);
        return coffee.MakeOrder();
    }
    public Coffee DeliverOrder()
    {
        System.Console.WriteLine("Pedido entregado.");
        return _orders.Dequeue();
    }
    public Coffee AddCream(Coffee coffee)
    {
        if (coffee.Cream == false) {
            return new CreamDecorator(coffee);
        }
        System.Console.WriteLine("El café ya tiene crema.");
        return coffee;
    }
    public Coffee AddMilk(Coffee coffee){
        if (coffee.Milk == false) {
            return new MilkDecorator(coffee);
        }
        System.Console.WriteLine("El café ya tiene leche.");
        return coffee;
    }
    public Coffee AddChocolate(Coffee coffee){
        if (coffee.Chocolates < 2) {
            return new ChocolateDecorator(coffee);
        }
        System.Console.WriteLine("El café ya tiene el máximo de chocolates.");
        return coffee;
    }
}
