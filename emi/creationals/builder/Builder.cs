using System.Net.Http.Headers;

namespace builder;

public interface Builder
{
    void reset();
    void buildSize(Sizes pizzaSize);
    void buildDoughType(DoughType doughType);
    void addIngredient(IngredientType ingredient);
    Product GetProduct();
}
