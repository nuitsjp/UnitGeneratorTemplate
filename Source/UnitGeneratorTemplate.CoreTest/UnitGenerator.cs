using UnitGenerator;

namespace UnitGeneratorTemplate.CoreTest
{

    [UnitOf(typeof(int), UnitGenerateOptions.EntityFrameworkValueConverter)]
    public partial struct EntityFrameworkValueConverter
    {
    }

    [UnitOf(typeof(int), UnitGenerateOptions.ImplicitOperator | UnitGenerateOptions.ParseMethod | UnitGenerateOptions.MinMaxMethod | UnitGenerateOptions.ArithmeticOperator | UnitGenerateOptions.ValueArithmeticOperator | UnitGenerateOptions.Comparable | UnitGenerateOptions.Validate | UnitGenerateOptions.JsonConverter | UnitGenerateOptions.MessagePackFormatter | UnitGenerateOptions.DapperTypeHandler | UnitGenerateOptions.EntityFrameworkValueConverter, "{0:000-000-000}")]
    public partial struct Full
    {
    }

}
