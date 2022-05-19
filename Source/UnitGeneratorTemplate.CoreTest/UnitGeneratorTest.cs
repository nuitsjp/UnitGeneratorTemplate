using System.Text.Json;
using FluentAssertions;
using MessagePack;

namespace UnitGeneratorTemplate.CoreTest
{
    public class UnitGeneratorTest
    {
        [Fact]
        public void EntityFrameworkValueConverter()
        {
            var converter = new EntityFrameworkValueConverter.EntityFrameworkValueConverterValueConverter();
        }

        [Fact]
        public void Full()
        {
            var actual = new Full(1);

            // Format
            actual.ToString().Should().Be("000-000-001");

            // ImplicitOperator
            int intValue = actual;
            intValue.Should().Be(actual.AsPrimitive());

            // ParseMethod
            CoreTest.Full.Parse("1")
                .AsPrimitive().Should().Be(1);


            // MinMaxMethod
            var small = new Full(1);
            var large = new Full(2);
            CoreTest.Full.Min(small, large).Should().Be(small);
            CoreTest.Full.Max(small, large).Should().Be(large);

            // ArithmeticOperator
            (small + large).Should().Be(new Full(3));

            // ValueArithmeticOperator
            var valueArithmeticOperator = new Full(1);
            valueArithmeticOperator++;
            (valueArithmeticOperator).Should().Be(new Full(2));

            // Comparable
            (new Full(1) < new Full(2)).Should().BeTrue();

            // Validate
            FluentActions.Invoking(() => new Full(11))
                .Should().Throw<Exception>("Invalid value range: 11");

            // JsonSerializer
            JsonSerializer.Serialize(new Full(1))
                .Should().Be("1");

            // MessagePackFormatter
            MessagePackSerializer.Serialize(new Full(1))
                .Should().BeEquivalentTo(new byte[] { 1 });

            // DapperTypeHandler
#pragma warning disable CS0618
            Dapper.SqlMapper.LookupDbType(typeof(Full), nameof(Full), true, out var handler);
#pragma warning restore CS0618
            handler.GetType().Should().Be(typeof(Full.FullTypeHandler));

            // EntityFrameworkValueConverter
            var converter = new Full.FullValueConverter();

        }
    }
}