using System.Collections;
using System.Collections.Generic;
using UnitTestingLearn.Calculators;
using Xunit;


namespace UnitTests;

public class CalculatorTest
{
    [Fact]
    public void Example()
    {
        Assert.Equal(0, new BrokenCalculator().Add(0, 0));
    }


    private static IEnumerable<object[]> DataSubtract()
    {
        for (int i = 0; i < 100; i++)
        {
            yield return new object[] {i, -i};
        }
    }


    [Theory]
    [InlineData(10, -10)]
    [MemberData(nameof(DataSubtract))]
    [ClassData(typeof(TestDataGenerator))]
    public void Subtract(int left, int right)
    {
        Assert.Equal(0, new BrokenCalculator().Subtract(left, right));
    }
    
    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new()
        {
            new object[] {0, 0},
            new object[] {0, 0}
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

