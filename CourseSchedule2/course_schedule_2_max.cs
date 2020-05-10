public class Solution {
    public List<int> path = new List<int>();
    public Stack<int> stack = new Stack<int>();
    
    public bool BFS(int startIdx, int numCourses, int[][] prerequisites) { 
        stack.Push(startIdx);
        do {
            if (path.Contains(startIdx)) {
                return false;
            }
            path.Add(startIdx);
            
            for(int i = 0; i < prerequisites.Length; i++) {
                if (prerequisites[i][1] == startIdx) {
                    bool isDependent = false;
                    for(int j = 0; j < prerequisites.Length; j++) {
                        if (prerequisites[j][0] == prerequisites[i][0] &&
                            !path.Contains(prerequisites[j][1])) {
                            isDependent = true;
                        }
                    }
                    if (!isDependent) {
                        stack.Push(prerequisites[i][0]);   
                    }
                }
            }
            startIdx = stack.Pop();
        } while (stack.Count() != 0);
        
        return true;
    }
    
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        int i = 0;
        bool bfsNotCyclic = true;
        while (i < numCourses && bfsNotCyclic && path.Count() != numCourses) {
            bool isDependent = false;
            for(int j = 0; j < prerequisites.Length; j++) {
                if (prerequisites[j][0] == i) {
                    isDependent = true;
                }
            }
            if (!isDependent) {
                bfsNotCyclic = BFS(i, numCourses, prerequisites);   
            }
            i++;
        }
        
        return bfsNotCyclic && path.Count() == numCourses ? path.ToArray() : new int[0];
    }
}