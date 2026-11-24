using LanternHollow;
using Xunit;

namespace LanternHollow.Tests;

// The smoke test only proves that the test project builds and runs,
// and that it can see the game's numbers.
public class SmokeTests
{
    [Fact]
    public void Tuning_Has_Sane_Gravity()
    {
        Assert.InRange(Tuning.Gravity, 800f, 3000f);
    }
}
