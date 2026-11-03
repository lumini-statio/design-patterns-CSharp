namespace builder;

public class Pizzeria
{
    private Builder _builder;
    public Pizzeria(Builder builder)
    {
        _builder = builder;
    }
    public void ChangeBuilder(Builder builder)
    {
        _builder = builder;
    }
    public void MakePizza(PizzaType type)
    {
        _builder.reset();

        if (type == PizzaType.MOZZARELLA)
        {
            _builder.buildSize(Sizes.LARGE);
            _builder.buildDoughType(DoughType.STONE);
            _builder.addIngredient(IngredientType.OLIVES);
        } 
        else if (type == PizzaType.NAPOLITANA)
        {
            _builder.buildSize(Sizes.MEDIUM);
            _builder.buildDoughType(DoughType.THIN);
            _builder.addIngredient(IngredientType.TOMATO);
            _builder.addIngredient(IngredientType.GARLIC);
        }
    }
}
