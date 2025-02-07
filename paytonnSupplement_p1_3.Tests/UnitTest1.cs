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
        
    }
}