using System.Text;

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

        /// <summary>
        /// Reads the content of an ASCII file.
        /// </summary>
        /// <param name="filePath">The path to the ASCII file that is read.</param>
        /// <returns>Returns the content inside of the ASCII file as a string.</returns>
        public static string ReadAsciiFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        /// <summary>
        /// Reads the content of a binary file.
        /// </summary>
        /// <param name="filePath">The path to the binary file that is read.</param>
        /// <returns>Returns the content of the binary file.</returns>
        public static byte[] ReadBinaryFile(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

        public static void CompareFileSizes()
        {
            throw new System.NotImplementedException();
        }

    }
}
