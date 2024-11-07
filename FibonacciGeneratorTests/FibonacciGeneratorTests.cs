using FibonacciGenerator;
using NUnit.Framework;

namespace FibonacciGeneratorTests;

[TestFixture]
public class FibonacciTests
{
    [Test]
    public void Generate_ShallThrowException_IfNIsSmallerThanZero()
    {
        Assert.Throws<ArgumentException>(
            () => Fibonacci.Generate(-1));
    }
    [Test]
    public void Generate_ShallThrowException_IfNIsLargerThan46()
    {
        Assert.Throws<ArgumentException>(
            () => Fibonacci.Generate(47));
    }
}