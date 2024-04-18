namespace Test_Merge_Sorted_Array;

[TestFixture]
public class SolutionTests
{
  [Test]
  public void MergeTest()
  {
    // Arrange
    var solution = new Solution();
    int[] nums1 = {1, 2, 3, 0, 0, 0};
    int m = 3;
    int[] nums2 = {2, 5, 6};
    int n = 3;
    int[] expected = {1, 2, 2, 3, 5, 6};

    // Act
    solution.Merge(nums1, m, nums2, n);

    // Assert
    Assert.That(nums1, Is.EqualTo(expected));
  }
}