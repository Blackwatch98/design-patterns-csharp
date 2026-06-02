using AbstractFactory.PatternSolution.Factories;
using NaiveUiRenderer = AbstractFactory.NaiveSolution.UiRenderer;
using NaiveUiTheme = AbstractFactory.NaiveSolution.UiTheme;

using PatternUiRenderer = AbstractFactory.PatternSolution.UiRenderer;
using PatternUiTheme = AbstractFactory.PatternSolution.UiTheme;

var renderer = new NaiveUiRenderer();

Console.WriteLine("Abstract Factory - Naive Solution");
Console.WriteLine("---------------------------------");

NaiveRenderUi(NaiveUiTheme.Windows);
Console.WriteLine();
NaiveRenderUi(NaiveUiTheme.MacOs);

/**************************************************************/

Console.WriteLine("Abstract Factory - Pattern Solution");
Console.WriteLine("-----------------------------------");

PatternRenderUi(PatternUiTheme.Windows, new WindowsUiFactory());
Console.WriteLine();
PatternRenderUi(PatternUiTheme.MacOs, new MacOsUiFactory());

void NaiveRenderUi(NaiveUiTheme theme)
{
    Console.WriteLine($"Theme: {theme}");
    Console.WriteLine(renderer.Render(theme));
}

void PatternRenderUi(PatternUiTheme theme, IUiFactory uiFactory)
{
    var renderer = new PatternUiRenderer(uiFactory);

    Console.WriteLine($"Theme: {theme}");
    Console.WriteLine(renderer.Render());
}