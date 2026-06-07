using AbstractFactory.PatternSolution.Components.Buttons;
using AbstractFactory.PatternSolution.Components.Checkboxes;

namespace AbstractFactory.PatternSolution.Factories;

public interface IUiFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
