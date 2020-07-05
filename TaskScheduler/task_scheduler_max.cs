public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int ticks = 0;
        int countMaxTasks = 0;
        Dictionary<char, int> tasksByLetter = new Dictionary<char, int>();
        for (int i = 0; i < tasks.Length; i++) {
            if (!tasksByLetter.ContainsKey(tasks[i])) {
                tasksByLetter.Add(tasks[i], 1);
            } else {
                tasksByLetter[tasks[i]]++;
            }
        }
        int maxTasks = tasksByLetter.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
        foreach(var task in tasksByLetter) {
            if (task.Value == maxTasks) {
                countMaxTasks++;
            }
        }
        ticks = (maxTasks - 1) * (n + 1) + countMaxTasks;
        
        return ticks < tasks.Length?  tasks.Length : ticks;
    }
}
