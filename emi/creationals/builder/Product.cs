namespace builder;

public abstract class Product
{
    protected Sizes _size;
    protected DoughType _doughType;
    protected List<IngredientType> _ingredients;
    public Product()
    {
        _ingredients = new();
    }
    public abstract void addIngredient(IngredientType ingredient);
    public abstract void GetIngredients();
    public abstract void ProductInfo();
}
