using CSharpKatas;

namespace TestCSharpKatas;

[TestFixture]
public class TestIsBalanced
{
    [Test]
    public void TestTrivialBalanced()
    {
        Assert.That(Functions.IsBalanced(""));
        Assert.That(Functions.IsBalanced("aaa"));
        Assert.That(Functions.IsBalanced("()"));
        Assert.That(Functions.IsBalanced("{}"));
        Assert.That(Functions.IsBalanced("[]"));
    }

    [Test]
    public void TestTrivialUnbalanced()
    {
        Assert.That(!Functions.IsBalanced("("));
        Assert.That(!Functions.IsBalanced(")"));
        Assert.That(!Functions.IsBalanced("{"));
        Assert.That(!Functions.IsBalanced("]"));
        Assert.That(!Functions.IsBalanced("{(["));
    }

    [Test]
    public void TestUnbalancedOrder()
    {
        Assert.That(!Functions.IsBalanced("({)}"));
        Assert.That(!Functions.IsBalanced("(a(b}c{)"));
    }

    [Test]
    public void TestComplexBalanced()
    {
        Assert.That(Functions.IsBalanced("((())())"));
        Assert.That(Functions.IsBalanced("(({[][abcde]})())"));
    }

}