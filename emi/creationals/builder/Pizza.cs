namespace builder;

public class Pizza : Product
{
    public Sizes Size
    {
        get { return _size; }
        set { _size = value; }
    }
    public DoughType DoughType_
    {
        get { return _doughType; }
        set { _doughType = value; }
    }
    public Pizza() : base() {}
    public override void addIngredient(IngredientType ingredient)
    {
        _ingredients.Add(ingredient);
    }
    public override void GetIngredients()
    {
        foreach (var ingredient in _ingredients)
        {
            System.Console.WriteLine($"{ingredient}");
        }
    }
    public override void ProductInfo()
    {
        System.Console.WriteLine($"{Size} pizza, {DoughType_} crust: ");
        GetIngredients();
    }
}
