using AbstractFactory.PatternSolution.Factories;
using Shouldly;

using PatternUiRenderer = AbstractFactory.PatternSolution.UiRenderer;

namespace AbstractFactory.Tests.PatternSolution;

public class UiRendererTests
{
    [Fact]
    public void Render_WithWindowsUiFactory_ReturnsWindowsComponents()
    {
        var renderer = new PatternUiRenderer(new WindowsUiFactory());

        var result = renderer.Render();

        result.ShouldBe($"""
                         Rendering Windows button
                         Rendering Windows checkbox
                         """);
    }

    [Fact]
    public void Render_WithMacOsUiFactory_ReturnsMacOsComponents()
    {
        var renderer = new PatternUiRenderer(new MacOsUiFactory());

        var result = renderer.Render();

        result.ShouldBe($"""
                         Rendering Mac OS button
                         Rendering Mac OS checkbox
                         """);
    }
}