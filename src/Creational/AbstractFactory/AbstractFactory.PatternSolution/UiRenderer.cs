using AbstractFactory.PatternSolution.Factories;

namespace AbstractFactory.PatternSolution;

public class UiRenderer
{
    private readonly IUiFactory _uiFactory;
    public UiRenderer(IUiFactory uiFactory)
    {
        _uiFactory = uiFactory;
    }

    public string Render()
    {
        var button = _uiFactory.CreateButton();
        var checkbox = _uiFactory.CreateCheckbox();
        return $"{button.Render()}{Environment.NewLine}{checkbox.Render()}";
    }
}
