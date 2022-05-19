using UnitGenerator;

namespace GettingStarted
{

    /// <summary>
    /// ID of Unit
    /// </summary>
    [UnitOf(typeof(int), UnitGenerateOptions.ImplicitOperator)]
    public partial struct UserId
    {
    }

}
