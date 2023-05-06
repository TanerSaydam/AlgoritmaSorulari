namespace _14.KarakokunuBul
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int number1 = 4;
            int number2 = 8;
            int number3 = 9;
            int number4 = 16;

            //Act
            int result1 = MySqrt(number1);
            int result2 = MySqrt(number2);
            int result3 = MySqrt(number3);
            int result4 = MySqrt(number4);

            //Assert
            Assert.Equal(2, result1);
            Assert.Equal(2, result2);
            Assert.Equal(3, result3);
            Assert.Equal(4, result4);
            
        }

        public int MySqrt(int x)
        {
            double i = 0;
            while(i*i <= x) // 2 * 2 <= 4
            {
                if ((i * i) <= x && (i + 1) * (i + 1) > x)
                    return (int)i;

                i++;
            }

            return 0;
        }
    }
}