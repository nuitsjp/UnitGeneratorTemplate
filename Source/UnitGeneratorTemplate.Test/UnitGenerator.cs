using UnitGenerator;

namespace UnitGeneratorTemplate.Test
{

    [UnitOf(typeof(int))]
    public partial struct UserId
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.None, "{0:###,###,###}")]
    public partial struct Format
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.ImplicitOperator)]
    public partial struct ImplicitOperator
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.ParseMethod)]
    public partial struct ParseMethod
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.MinMaxMethod)]
    public partial struct MinMaxMethod
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.ArithmeticOperator)]
    public partial struct ArithmeticOperator
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.ValueArithmeticOperator)]
    public partial struct ValueArithmeticOperator
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.Comparable)]
    public partial struct Comparable
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.Validate)]
    public partial struct Validatable
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.JsonConverter)]
    public partial struct JsonConverter
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.MessagePackFormatter)]
    public partial struct MessagePackFormatter
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.DapperTypeHandler)]
    public partial struct DapperTypeHandler
    {
    }

}
