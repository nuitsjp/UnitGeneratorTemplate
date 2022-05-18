#if NET6_0_OR_GREATER
#else
// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices;


public class ModuleInitializerAttribute : Attribute
{
}
#endif
