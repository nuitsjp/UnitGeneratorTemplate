using UnitGenerator;

namespace UnitGeneratorTemplate.CoreTest
{

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.EntityFrameworkValueConverter)]
    public partial struct EntityFrameworkValueConverter
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.ImplicitOperator | UnitGenerateOptions.ParseMethod | UnitGenerateOptions.MinMaxMethod | UnitGenerateOptions.ArithmeticOperator | UnitGenerateOptions.ValueArithmeticOperator | UnitGenerateOptions.Comparable | UnitGenerateOptions.Validate | UnitGenerateOptions.JsonConverter | UnitGenerateOptions.MessagePackFormatter | UnitGenerateOptions.DapperTypeHandler | UnitGenerateOptions.EntityFrameworkValueConverter, "{0:000-000-000}")]
    public partial struct Full
    {
        private partial void Validate()
        {
            if (value <= 10 is false) throw new Exception($"Invalid value range: {value}");
        }
    }

}
