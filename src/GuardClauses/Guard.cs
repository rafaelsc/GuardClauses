using JetBrainsNotNullAttribute = JetBrains.Annotations.NotNullAttribute;

namespace Ardalis.GuardClauses
{
    /// <summary>
    /// Simple interface to provide a generic mechanism to build guard clause extension methods from.
    /// </summary>
    public interface IGuardClause
    {
    }

    public interface IGuardDebugClause
    {
    }

    /// <summary>
    /// An entry point to a set of Guard Clauses defined as extension methods on IGuardClause.
    /// </summary>
    /// <remarks>See http://www.weeklydevtips.com/004 on Guard Clauses</remarks>
    public class Guard : IGuardClause, IGuardDebugClause
    {
        /// <summary>
        /// An entry point to a set of Guard Clauses.
        /// </summary>
        [JetBrainsNotNull] public static IGuardClause Against { get; } = new Guard();

        [JetBrainsNotNull] public static IGuardDebugClause DebugAgainst { get; } = new Guard();

        private Guard() { }
    }
}
