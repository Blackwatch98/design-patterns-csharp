using Shouldly;

using UiRenderer = AbstractFactory.NaiveSolution.UiRenderer;
using UiTheme = AbstractFactory.NaiveSolution.UiTheme;

namespace AbstractFactory.Tests.NaiveSolution;

public class UiRendererTests
{
    [Fact]
    public void Render_ForWindowsTheme_ReturnsWindowsComponents()
    {
        var renderer = new UiRenderer();

        var result = renderer.Render(UiTheme.Windows);

        result.ShouldBe($"""
                     Rendering Windows button
                     Rendering Windows checkbox
                     """);
    }

    [Fact]
    public void Render_ForMacOsTheme_ReturnsMacOsComponents()
    {
        var renderer = new UiRenderer();

        var result = renderer.Render(UiTheme.MacOs);

        result.ShouldBe($"""
                     Rendering MacOS button
                     Rendering MacOS checkbox
                     """);
    }
}
