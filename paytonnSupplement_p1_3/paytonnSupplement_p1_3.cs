using System.Text;

namespace paytonnSupplement_p1_3
{
    public class paytonnSupplement_p1_3
    {
        public static void CreateAsciiFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }

        public static void CreateBinaryFile(string filePath, byte[] content)
        {
            throw new System.NotImplementedException();
        }

        public static string ReadAsciiFile(string filePath)
        {
            throw new System.NotImplementedException();
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
