using System;


namespace R5T.B0005
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Example : IExample
    {
        #region Static
        
        public static Example Instance { get; } = new();

        #endregion
    }
}