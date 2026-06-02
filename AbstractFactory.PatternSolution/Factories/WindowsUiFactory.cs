using AbstractFactory.PatternSolution.Components.Buttons;
using AbstractFactory.PatternSolution.Components.Checkboxes;

namespace AbstractFactory.PatternSolution.Factories;

public class WindowsUiFactory : IUiFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }
}
