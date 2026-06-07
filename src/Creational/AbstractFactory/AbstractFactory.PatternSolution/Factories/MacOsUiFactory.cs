using AbstractFactory.PatternSolution.Components.Buttons;
using AbstractFactory.PatternSolution.Components.Checkboxes;

namespace AbstractFactory.PatternSolution.Factories;

public class MacOsUiFactory : IUiFactory
{
    public IButton CreateButton()
    {
        return new MacOsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacOsCheckbox();
    }
}
