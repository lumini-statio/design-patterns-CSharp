using builder;

var statement = """
A pizzeria records its orders in a system. Each pizza has a size, a type of crust, and
a list of ingredients. The current pizza constructor already takes six parameters—several
of which can be null—making it easy to get the order wrong.

All pizzas on the menu are assembled using the same process (first the size, then the
crust, and finally the ingredients); what varies is the content of each step. The goal is
to be able to construct pizzas from the menu by reusing this process, while also allowing
for the addition of new pizzas without modifying the pizza class itself.

To verify: construct a "muzzarella" (large, stone-baked crust, with olives) and a
"napolitana" (medium, thin crust, with tomato and garlic) using the same process.
Large pizza, stone-baked crust: mozzarella, olives
Medium pizza, thin crust: mozzarella, tomato, garlic
""";

Builder builder = new PizzaBuilder();

Pizzeria pizzeria = new Pizzeria(builder);

pizzeria.MakePizza(PizzaType.MOZZARELLA);
Pizza pizza = (Pizza)builder.GetProduct();
System.Console.WriteLine();

pizza.ProductInfo();

System.Console.WriteLine();

pizzeria.MakePizza(PizzaType.NAPOLITANA);
Pizza pizza2 = (Pizza)builder.GetProduct();
pizza2.ProductInfo();


System.Console.WriteLine();
