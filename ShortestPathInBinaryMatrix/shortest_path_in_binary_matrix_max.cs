public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        int N=grid.Length;
        if(grid[0][0]==1||grid[N-1][N-1]==1) return -1;
        int res=1;
        Queue<int[]> queue=new Queue<int[]>();
        queue.Enqueue(new int[]{0,0});
        while(queue.Count>0)
        {
            int levelsize=queue.Count;
            for(int i=0;i<levelsize;i++)
            {
                var cur=queue.Dequeue();
                int r=cur[0];
                int c=cur[1];
                if(r==N-1&&c==N-1) return res;
               
                if(valid(r-1,c-1,N,grid)) queue.Enqueue(new int[]{r-1,c-1});
                if(valid(r-1,c,N,grid)) queue.Enqueue(new int[]{r-1,c});
                if(valid(r,c-1,N,grid)) queue.Enqueue(new int[]{r,c-1});
                if(valid(r+1,c+1,N,grid)) queue.Enqueue(new int[]{r+1,c+1});
                if(valid(r+1,c,N,grid)) queue.Enqueue(new int[]{r+1,c});
                if(valid(r,c+1,N,grid)) queue.Enqueue(new int[]{r,c+1});
                if(valid(r+1,c-1,N,grid)) queue.Enqueue(new int[]{r+1,c-1});
                if(valid(r-1,c+1,N,grid)) queue.Enqueue(new int[]{r-1,c+1});
            }
            res++;
        }        
        return -1;
    }
    
    public bool valid(int r, int c, int N, int[][] grid)
    {   
        if(!(r>=0&&r<N&&c>=0&&c<N)) return false;
        if (grid[r][c]==1) return false;
        
        grid[r][c]=1;
           
        return true;
    }
}
