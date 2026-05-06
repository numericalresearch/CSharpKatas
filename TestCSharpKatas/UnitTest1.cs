using CSharpKatas;

namespace TestCSharpKatas;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void TestIsPrime()
    {
        Assert.That(Functions.is_prime(2));
        Assert.That(Functions.is_prime(3));
        Assert.That(Functions.is_prime(5));
        Assert.That(!Functions.is_prime(10));
        Assert.That(!Functions.is_prime(100));
    }

    [Test]
    public void TestPrimesBelow()
    {
        int[] all_expected = [2, 3, 5, 7, 11, 13, 17, 19, 23];

        foreach (var (expected, actual) in Enumerable.Zip(all_expected, Functions.PrimesBelow(30)))
        {
            Console.WriteLine("{0} == {1}", actual, expected);
            Assert.That(expected == actual);
        }
    }
}