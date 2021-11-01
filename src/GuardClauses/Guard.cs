using JetBrainsNotNullAttribute = JetBrains.Annotations.NotNullAttribute;

namespace Ardalis.GuardClauses
{
    /// <summary>
    /// Simple interface to provide a generic mechanism to build guard clause extension methods from.
    /// </summary>
    public interface IGuardClause
    {
    }

    /// <summary>
    /// Simple interface to provide a generic mechanism to build guard clause extension methods from.
    /// </summary>
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

        /// <summary>
        /// An entry point to a set of Guard Clauses to ran only in Debug.
        /// </summary>
        [JetBrainsNotNull] public static IGuardDebugClause DebugAgainst { get; } = new Guard();

        private Guard() { }
    }
}
