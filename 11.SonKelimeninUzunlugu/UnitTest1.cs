namespace _11.SonKelimeninUzunlugu
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange            
            string s1 = "Hello World";
            string s2 = "   fly me   to   the moon  ";
            string s3 = "luffy is still joyboy";

            //Act
            var reuslt1 = LengthOfLastWord(s1);
            var reuslt2 = LengthOfLastWord(s2);
            var reuslt3 = LengthOfLastWord(s3);

            //Assert
            Assert.Equal(5, reuslt1);
            Assert.Equal(4, reuslt2);
            Assert.Equal(6, reuslt3);

        }

        public int LengthOfLastWord(string s)
        {
            var result = s.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return result[^1].Length;
        }

    }
}