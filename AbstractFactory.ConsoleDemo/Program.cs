using NaiveUiRenderer = AbstractFactory.NaiveSolution.UiRenderer;
using NaiveUiTheme = AbstractFactory.NaiveSolution.UiTheme;

var renderer = new NaiveUiRenderer();

Console.WriteLine("Abstract Factory - Naive Solution");
Console.WriteLine("---------------------------------");

RenderUi(NaiveUiTheme.Windows);
Console.WriteLine();
RenderUi(NaiveUiTheme.MacOs);

void RenderUi(NaiveUiTheme theme)
{
    Console.WriteLine($"Theme: {theme}");
    Console.WriteLine(renderer.Render(theme));
}