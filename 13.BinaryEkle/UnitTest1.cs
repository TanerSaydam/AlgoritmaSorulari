namespace _13.BinaryEkle
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange            
            string a1 = "11";
            string b1 = "1";

            string a2 = "1010";
            string b2 = "1011";

            //Act
            var result1 = AddBinary(a1, b1);
            var result2 = AddBinary(a2, b2);

            //Assert
            Assert.Equal("100", result1);
            Assert.Equal("10101", result2);
        }

        public string AddBinary(string a, string b)
        {
            //0 => 48
            //1 => 49
            
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            string result = "";

            while (i >= 0 || j>= 0)
            {
                int sum = carry;

                if(i >= 0)
                {
                    sum += a[i] - '0'; //49 - 48 = 1 || 48 - 48 =0 //// 1
                    i--;
                }

                if(j >= 0)
                {
                    sum += b[j] - '0'; //1
                    j--;
                }//sum = 2;

                carry = sum / 2; //1;
                result = (sum % 2) + result; /// 2 % 2 => 0 - 3 / 2 =>1 -- 4 / 2 => 0 -- 5 / 2 =>1
            }

            if (carry > 0) result = carry + result;

            return result;
        }
    }
}