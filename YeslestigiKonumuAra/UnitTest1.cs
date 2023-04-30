namespace _10.YeslestigiKonumuAra
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange            
            int[] nums = { 1, 3, 5, 6};

            //Act            
            int result1 = SearchInsert(nums, 5);
            int result2 = SearchInsert(nums, 2);
            int result3 = SearchInsert(nums, 7);

            //Assert
            Assert.Equal(2, result1);
            Assert.Equal(1, result2);
            Assert.Equal(4, result3);
            
        }

        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target || nums[i] > target) return i;
            }

            return nums.Length; 
        }
    }
}