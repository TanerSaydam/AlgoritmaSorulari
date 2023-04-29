namespace _9.EslesenIlkIndexiBul
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange            
            string haystack1 = "sadbutsad";
            string needle1 = "sad";

            string haystack2 = "sadbutsad";
            string needle2 = "but";

            //Act
            int result1 = StrStr(haystack1, needle1);
            int result2 = StrStr(haystack2, needle2);

            //Assert
            Assert.Equal(0, result1);
            Assert.Equal(3, result2);
        }

        public int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}