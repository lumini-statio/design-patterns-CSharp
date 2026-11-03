namespace builder;

public class PizzaBuilder : Builder
{
    private Pizza pizza;
    public PizzaBuilder()
    {
        pizza = new();
    }
    public void addIngredient(IngredientType ingredient)
    {
        pizza.addIngredient(ingredient);
    }

    public void buildDoughType(DoughType doughType)
    {
        pizza.DoughType_ = doughType;
    }

    public void buildSize(Sizes pizzaSize)
    {
        pizza.Size = pizzaSize;
    }

    public void reset()
    {
        pizza = new Pizza();
    }
    public Product GetProduct()
    {
        return pizza;
    }
}
