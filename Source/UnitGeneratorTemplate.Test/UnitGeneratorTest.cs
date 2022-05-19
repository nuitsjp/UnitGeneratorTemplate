using FluentAssertions;
using System.Text.Json;
using MessagePack;

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

        [Fact]
        public void Format()
        {
            var actual = new Format(1234);
            actual.ToString().Should().Be("1,234");
        }

        [Fact]
        public void ImplicitOperator()
        {
            var actual = new ImplicitOperator(1);
            int intValue = actual;
            intValue.Should().Be(actual.AsPrimitive());
        }

        [Fact]
        public void ParseMethod()
        {
            var actual = Test.ParseMethod.Parse("1");
            actual.AsPrimitive().Should().Be(1);
        }

        [Fact]
        public void MinMaxMethod()
        {
            var small = new MinMaxMethod(1);
            var large = new MinMaxMethod(2);

            Test.MinMaxMethod.Min(small, large).Should().Be(small);
            Test.MinMaxMethod.Max(small, large).Should().Be(large);
        }

        [Fact]
        public void ArithmeticOperator()
        {
            var small = new ArithmeticOperator(1);
            var large = new ArithmeticOperator(2);
            (small + large).Should().Be(new ArithmeticOperator(3));
        }

        [Fact]
        public void ValueArithmeticOperator()
        {
            var actual = new ValueArithmeticOperator(1);
            actual++;
            (actual).Should().Be(new ValueArithmeticOperator(2));
        }

        [Fact]
        public void Comparable()
        {
            (new Comparable(1) < new Comparable(2)).Should().BeTrue();
        }

        [Fact]
        public void Validate()
        {
            FluentActions.Invoking(() => new Validatable(21))
                .Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void JsonConverter()
        {
            JsonSerializer.Serialize(new JsonConverter(1))
                .Should().Be("1");
        }

        [Fact]
        public void MessagePackFormatter()
        {
            MessagePackSerializer.Serialize(new MessagePackFormatter(1))
                .Should().BeEquivalentTo(new byte[] { 1 });
        }

        [Fact]
        public void DapperTypeHandler()
        {
#pragma warning disable CS0618
            Dapper.SqlMapper.LookupDbType(typeof(DapperTypeHandler), nameof(DapperTypeHandler), true, out var handler);
#pragma warning restore CS0618
            handler.GetType().Should().Be(typeof(DapperTypeHandler.DapperTypeHandlerTypeHandler));
        }
    }
}