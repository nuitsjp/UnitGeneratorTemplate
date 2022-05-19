using UnitGenerator;

namespace UnitGeneratorTemplate.Test
{

    /// <summary>
    /// ID of Unit
    /// </summary>
    [UnitOf(typeof(int))]
    public partial struct UserId
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.None, "{0:###,###,###}")]
    public partial struct Format
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.ImplicitOperator)]
    public partial struct ImplicitOperator
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.ParseMethod)]
    public partial struct ParseMethod
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.MinMaxMethod)]
    public partial struct MinMaxMethod
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.ArithmeticOperator)]
    public partial struct ArithmeticOperator
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.ValueArithmeticOperator)]
    public partial struct ValueArithmeticOperator
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.Comparable)]
    public partial struct Comparable
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.Validate)]
    public partial struct Validatable
    {
        private partial void Validate()
        {
            if (value <= 5 is false) throw new InvalidOperationException($"Invalid value range: {value}");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.Validate)]
    public partial struct SelfValidatable
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.JsonConverter)]
    public partial struct JsonConverter
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.MessagePackFormatter)]
    public partial struct MessagePackFormatter
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.DapperTypeHandler)]
    public partial struct DapperTypeHandler
    {
    }

}
