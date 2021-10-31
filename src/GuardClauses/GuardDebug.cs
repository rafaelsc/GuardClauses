using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using JetBrainsNoEnumerationAttribute = JetBrains.Annotations.NoEnumerationAttribute;
using JetBrainsNotNullAttribute = JetBrains.Annotations.NotNullAttribute;

namespace Ardalis.GuardClauses
{
    public static class GuardDebug
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="guardClause"></param>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <param name="message">Optional. Custom error message</param>
        /// <returns><paramref name="input" /> if the value is not null.</returns>
        [Conditional("DEBUG")]
        public static void Null<T>([JetBrainsNotNull] this IGuardDebugClause guardClause, [NotNull, JetBrainsNotNull][ValidatedNotNull][JetBrainsNoEnumeration] T input, [JetBrainsNotNull] string parameterName, string? message = null)
        {
            Guard.Against.Null(input, parameterName, message);
        }
    }
}
