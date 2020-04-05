import scala.collection.mutable.ListBuffer

object Solution extends App {

  def permute(nums: Array[Int]): List[List[Int]] = {
    val rootBuilder: ListBuffer[List[Int]] = ListBuffer.empty

    def permute(i: Int): Unit =
      if (i == nums.length) {
        rootBuilder.addOne(nums.toList)
      } else {
        var j = i
        while (j < nums.length) {
          swap(i, j)
          permute(i + 1)
          swap(i, j)
          j += 1
        }
      }

    def swap(i: Int, j: Int): Unit = {
      val c = nums(i)
      nums(i) = nums(j)
      nums(j) = c
    }

    permute(0)
    rootBuilder.toList
  }
}