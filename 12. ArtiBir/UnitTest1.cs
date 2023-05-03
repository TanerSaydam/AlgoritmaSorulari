using NuGet.Frameworks;

namespace _12._ArtiBir
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 4,3,2,1 };
            int[] nums3 = { 9 };

            //Act
            var result1= PlusOne(nums1);
            var result2= PlusOne(nums2);
            var result3= PlusOne(nums3);

            //Assert
            Assert.Equal(new int[] { 1, 2, 4 }, result1);
            Assert.Equal(new int[] { 4,3,2,2 }, result2);
            Assert.Equal(new int[] { 1,0 }, result3);

        }

        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length -1; i >= 0; i--) //2,8,9 -- 2 9 0 -- 999 => 1000
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            return newDigits;
        }
    }
}