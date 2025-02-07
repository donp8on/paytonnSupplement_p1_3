using System.Text;

namespace paytonnSupplement_p1_3.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldCreateAsciiFile_CreatesFileWithContent()
        {
            string filePath = "test_ascii.txt";
            string content = "Hello, World!";

            paytonnSupplement_p1_3.CreateAsciiFile(filePath, content);

            Assert.True(File.Exists(filePath));
            string fileContent = File.ReadAllText(filePath);
            Assert.Equal(content, fileContent);
        }

        [Fact]
        public void ShouldCreateBinaryFile_CreatesFileWithBinaryContent()
        {
            string filePath = "test_binary.bin";
            byte[] content = Encoding.UTF8.GetBytes("Hello, World!");

            paytonnSupplement_p1_3.CreateBinaryFile(filePath, content);

            Assert.True(File.Exists(filePath));
            byte[] fileContent = File.ReadAllBytes(filePath);
            Assert.Equal(content, fileContent);
        }

    }
}