using System.Reflection;

namespace ShareInvest;

public static class TrConstructor
{
    public static Assembly Assembly
    {
        get => Assembly.GetExecutingAssembly();
    }
}