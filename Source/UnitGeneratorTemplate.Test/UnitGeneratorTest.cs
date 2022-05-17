using FluentAssertions;

namespace UnitGeneratorTemplate.Test
{
    public class UnitGeneratorTest
    {
        [Fact]
        public void Generate()
        {
            var userId = new UserId(1);
            userId.AsPrimitive().Should().Be(1);
        }
    }
}