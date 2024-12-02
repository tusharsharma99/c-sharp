var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new Mozarella());
pizza.AddIngredient(new TomatoSauce());

Console.WriteLine(pizza.Describe());

Console.ReadKey();

public class Pizza
{
    private List<Ingredients> _ingredients = new List<Ingredients>();

    public void AddIngredient(Ingredients ingredient) => _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}


public class Ingredients
{

}

public class Cheddar: Ingredients
{
    public string Name => "Cheddar Cheese";
    public int AgedForMonths { get; }

}

public class TomatoSauce : Ingredients
{
    public string Name => "Tomato Sauce";
    public int TomatoesIn100Grams { get; }

}

public class Mozarella : Ingredients
{
    public string Name => "Mozarella";
    public bool IsLight { get; }

}
