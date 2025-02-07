﻿using System.Text;

namespace paytonnSupplement_p1_3
{
    public class paytonnSupplement_p1_3
    {
        /// <summary>
        /// Creates a new ASCII file with the specified content.
        /// </summary>
        /// <param name="filePath">The path of the file to create.</param>
        /// <param name="content">The content inside of the file.</param>
        public static void CreateAsciiFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }

        /// <summary>
        /// Creates a new binary file with the specified content.
        /// </summary>
        /// <param name="filePath">The path of the file to create for binary.</param>
        /// <param name="content">The content inside of the file.</param>
        public static void CreateBinaryFile(string filePath, byte[] content)
        {
            File.WriteAllBytes(filePath, content);
        }

        public static string ReadAsciiFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public static byte[] ReadBinaryFile(string filePath)
        {
            throw new System.NotImplementedException();
        }

        public static void CompareFileSizes()
        {
            throw new System.NotImplementedException();
        }

    }
}
