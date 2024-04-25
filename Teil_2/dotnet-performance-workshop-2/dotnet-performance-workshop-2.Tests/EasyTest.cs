namespace EFK.DotnetPerformanceWorkshop.Part2.Tests;

using EFK.DotnetPerformanceWorkshop.Part2.Console;
using FluentAssertions;
using NUnit.Framework;

public class EasyTest
{
    [Test]
    public void ExampleEasy_TopData_CounterspellMustBeFound()
    {
        var result = ExampleEasy.TopData(["Counterspell"])
            .ToArray();

        // Assert
        result[0].Name
            .Should()
            .Be("Counterspell");

        result[0]
            .ManaCost
            .Should()
            .Be("{U}{U}");
    }

    [Test]
    public void ExampleEasy_TopData_ExampleInputMustBeFound()
    {
        var result = ExampleEasy.TopData(ExampleEasy.ExampleInput);

        // Assert
        result.Any(x => x.Name == "Sol Ring" && x.ManaCost == "{1}").Should().BeTrue();
        result.Any(x => x.Name == "Counterspell" && x.ManaCost == "{U}{U}").Should().BeTrue();
        result.Any(x => x.Name == "Lightning Bolt" && x.ManaCost == "{R}").Should().BeTrue();
        result.Any(x => x.Name == "Swords to Plowshares" && x.ManaCost == "{W}").Should().BeTrue();
        result.Any(x => x.Name == "Cyclonic Rift" && x.ManaCost == "{1}{U}").Should().BeTrue();
        result.Any(x => x.Name == "Rhystic Study" && x.ManaCost == "{2}{U}").Should().BeTrue();
        result.Any(x => x.Name == "Arcane Signet" && x.ManaCost == "{2}").Should().BeTrue();
        result.Any(x => x.Name == "Cultivate" && x.ManaCost == "{2}{G}").Should().BeTrue();
    }
    [Test]
    public void ExampleEasy_TopData_BlackLotusMustBeFound()
    {
        var result = ExampleEasy.TopData(["Black Lotus"])
            .ToArray();

        // Assert
        result[0].Name
            .Should()
            .Be("Black Lotus");

        result[0]
            .ManaCost
            .Should()
            .Be("{0}");
    }

    [Test]
    public void ExampleEasy_TopData_EmptyArrayMustReturnEmptyArray()
    {
        var result = ExampleEasy.TopData(Array.Empty<string>());

        // Assert
        result.Any()
            .Should()
            .BeFalse();
    }

    [Test]
    public void ExampleEasy_TopData_NullMustReturnEmptyArray()
    {
        var result = ExampleEasy.TopData(null!);

        // Assert
        result.Any()
            .Should()
            .BeFalse();
    }
}
