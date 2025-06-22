// Define an enum for a food type with values: soup, stew and gumbo
// Define a separate enum for ingredients: mushrooms, chicken, carrots, potatoes
// Define a separate enum for seasoning: spicy, salty, sweet

// Make a tuple variable to represent a soup composed of the three above enumeration types.

// Let the user pick a type, main ingredient, and seasoning from the allowed choices and fill the tuple with the results.
// Hint: You could give the user a menu to pick from or simply compare the
// user’s text input against specific strings to determine which enumeration value represents their choice.

// When done, display the contents of the soup tuple variable in a format like “Sweet Chicken Gumbo.”
// You don’t need to convert the enumeration value back to a string. Simply displaying an
// enumeration value with Write or WriteLine will display the name of the enumeration value.)

(SoupVariation soupType, IngredientType ingredient, SeasoningType seasoning) finalSoup = (AskSoupType("What kind of soup type would you like (Soup, Stew, Gumbo): "), AskIngredientType("What kind of main ingredient would you like (Mushroom, Chicken, Carrot, Potato): "), AskSeasoningType("What kind of seasoning would you like (Spicy, Salty, Sweet): "));
Console.ForegroundColor = ConsoleColor.Yellow;
string finalMessage = ($"You ordered a {finalSoup.seasoning} {finalSoup.ingredient} {finalSoup.soupType}");
Console.ResetColor();

foreach (char character in finalMessage)
{
    Console.Write(character);
    Thread.Sleep(25);
}
SoupVariation AskSoupType(string text)
{
    foreach (char character in text)
    {
        Console.Write(character);
        Thread.Sleep(25);
    }
    string input = Console.ReadLine();

    SoupVariation type = input switch
    {
        "Soup" => SoupVariation.Soup,
        "Stew" => SoupVariation.Stew,
        "Gumbo" => SoupVariation.Gumbo,
        _ => SoupVariation.Soup
    };
    return type;
}
IngredientType AskIngredientType(string text)
{
    foreach (char character in text)
    {
        Console.Write(character);
        Thread.Sleep(25);
    }
    string input = Console.ReadLine();

    IngredientType type = input switch
    {
        "Mushroom" => IngredientType.Mushroom,
        "Chicken" => IngredientType.Chicken,
        "Carrot" => IngredientType.Carrot,
        "Potato" => IngredientType.Potato,
        _ => IngredientType.Chicken
    };
    return type;
}
SeasoningType AskSeasoningType(string text)
{
    foreach (char character in text)
    {
        Console.Write(character);
        Thread.Sleep(25);
    }
    string input = Console.ReadLine();

    SeasoningType type = input switch
    {
        "Spicy" => SeasoningType.Spicy,
        "Salty" => SeasoningType.Salty,
        "Sweet" => SeasoningType.Sweet,
        _       => SeasoningType.Sweet
    };
    return type;
}

enum SoupVariation { Soup, Stew, Gumbo }
enum IngredientType { Mushroom, Chicken, Carrot, Potato }
enum SeasoningType { Spicy, Salty, Sweet }
