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

        /// <summary>
        /// Compares the file sizes of randomly generated ASCII text files and binary files.
        /// </summary>
        public static void CompareFileSizes()
        {
            int[] sizes = { 10, 100, 1000, 10000 };
            const string asciiChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            Random rand = new Random();

            foreach (int size in sizes)
            {
                // Generate a random ASCII-only string
                StringBuilder randomString = new StringBuilder();
                for (int i = 0; i < size; i++)
                {
                    randomString.Append(asciiChars[rand.Next(asciiChars.Length)]);
                }

                string finalString = randomString.ToString();

                // File paths
                string asciiFilePath = $"ascii_{size}.txt";
                string binaryFilePath = $"binary_{size}.bin";

                // Save to ASCII file
                File.WriteAllText(asciiFilePath, finalString, Encoding.ASCII);

                // Save to Binary file
                File.WriteAllBytes(binaryFilePath, Encoding.ASCII.GetBytes(finalString));

                // Get file sizes
                long asciiSize = new FileInfo(asciiFilePath).Length;
                long binarySize = new FileInfo(binaryFilePath).Length;

                // Print size comparison as a list
                Console.WriteLine($"String Length: {size}");
                Console.WriteLine($"ASCII File Size: {asciiSize} bytes");
                Console.WriteLine($"Binary File Size: {binarySize} bytes");
                Console.WriteLine("--------------------------------");
            }
        }

    }
}
