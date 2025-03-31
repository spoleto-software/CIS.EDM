using System;

namespace CIS.EDM.Exceptions
{
    /// <summary>
    /// The exception thrown when format version is wrong.
    /// </summary>
    [Serializable]
    public class FormatVersionException : Exception
    {
        /// <inheritdoc/>
        public FormatVersionException(string message)
            : base(message)
        {
        }
    }
}
