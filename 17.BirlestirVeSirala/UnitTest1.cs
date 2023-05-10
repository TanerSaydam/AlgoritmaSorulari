namespace _17.BirlestirVeSirala
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int[] expected = { 1, 2, 2, 3, 5, 6 };

            //Act
            Merge(nums1, m, nums2, n);

            //Assert
            Assert.Equal(expected, nums1);

        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for(int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
        }
    }
}