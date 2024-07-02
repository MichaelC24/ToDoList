namespace TestToDoList
{
    public class TestToDoList
    {
        [Fact]
        public void Test1()
        {

        }
        [Theory]
        [InlineData("test",DateTime(2024,1,3)]
        public void TestAdd(string Description, DateTime dateTime )
        {

        }
    }
}