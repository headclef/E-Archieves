using Microsoft.Build.Construction;
using Xunit;

namespace E_Archieves.Tests;

public class SolutionLoadTests
{
    [Fact]
    public void Solution_can_be_parsed()
    {
        var solutionPath = Path.Combine("..", "..", "E-Archieves.sln");
        var solution = SolutionFile.Parse(solutionPath);
        Assert.NotNull(solution);
    }
}
