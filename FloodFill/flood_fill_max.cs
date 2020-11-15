public class Point {
    public int X;
    public int Y;
    
    public Point(int x, int y) {
       X = x;
       Y = y;
    }
}

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        Stack<Point> stack = new Stack<Point>();
        int srcColor = image[sr][sc];
        stack.Push(new Point(sr, sc));
        while(stack.Count != 0) {
            Point p = stack.Pop();
            image[p.X][p.Y] = newColor;
            if (p.X - 1 >= 0 && image[p.X - 1][p.Y] == srcColor && image[p.X - 1][p.Y] != newColor) {
                stack.Push(new Point(p.X - 1, p.Y));
            }
            if (p.X + 1 < image.Length && image[p.X + 1][p.Y] == srcColor && image[p.X + 1][p.Y] != newColor) {
                stack.Push(new Point(p.X + 1, p.Y));
            }
            if (p.Y - 1 >= 0 && image[p.X][p.Y - 1] == srcColor && image[p.X][p.Y - 1] != newColor) {
                stack.Push(new Point(p.X, p.Y - 1));
            }
            if (p.Y + 1 < image[0].Length && image[p.X][p.Y + 1] == srcColor && image[p.X][p.Y + 1] != newColor) {
                stack.Push(new Point(p.X, p.Y + 1));
            }
        }
        
        return image;
    }
}
