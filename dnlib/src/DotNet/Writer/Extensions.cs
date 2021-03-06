﻿#region

using System.IO;

#endregion

namespace dnlib.DotNet.Writer
{
    /// <summary>
    ///     Extension methods
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///     Write zeros
        /// </summary>
        /// <param name="writer">this</param>
        /// <param name="count">Number of zeros</param>
        public static void WriteZeros(this BinaryWriter writer, int count)
        {
            if(count <= 0x20)
                for(var i = 0; i < count; i++)
                    writer.Write((byte) 0);
            else
                writer.Write(new byte[count]);
        }
    }
}