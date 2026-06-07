using AbstractFactory.NaiveSolution.Components;

namespace AbstractFactory.NaiveSolution;

public class UiRenderer
{
    public string Render(UiTheme theme)
    {
        if (theme == UiTheme.Windows)
        {
            var button = new WindowsButton();
            var checkbox = new WindowsCheckbox();

            return $"{button.Render()}{Environment.NewLine}{checkbox.Render()}";
        }

        if (theme == UiTheme.MacOs)
        {
            var button = new MacOsButton();
            var checkbox = new MacOsCheckbox();

            return $"{button.Render()}{Environment.NewLine}{checkbox.Render()}";
        }

        throw new ArgumentOutOfRangeException(nameof(theme));
    }
}