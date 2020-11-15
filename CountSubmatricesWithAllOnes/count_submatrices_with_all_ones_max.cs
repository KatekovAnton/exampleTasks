public class Solution
{
  public int NumSubmat(int[][] mat)
  {
    var rows = mat.Length;
    var cols = mat[0].Length;

    var nums = new int[rows, cols];

    for (var i = 0; i < rows; i++)
    {
      for (var j = 0; j < cols; j++)
      {
        if (j == 0)
          nums[i, j] = mat[i][j];
        else
          nums[i, j] = mat[i][j] == 1 ? nums[i, j - 1] + 1 : 0;
      }
    }

    var ans = new int[rows, cols];

    for (var i = 0; i < rows; i++)
    {
      for (var j = 0; j < cols; j++)
      {
        if (i == 0)
        {
          ans[i, j] = nums[i, j];
          continue;
        }

        ans[i, j] = nums[i, j];

        var min = nums[i, j];
        for (var k = i - 1; k >= 0; k--)
        {
          min = Math.Min(min, nums[k, j]);
          ans[i, j] += min;
        }
      }
    }

    var res = 0;
    for (var i = 0; i < rows; i++)
      for (var j = 0; j < cols; j++)
        res += ans[i, j];

    return res;
  }
}
