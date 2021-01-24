public class Solution {
    private HashSet<string> seq = new HashSet<string>();
    
    public int NumTilePossibilities(string tiles) {
        backTrack(tiles, "", new bool[tiles.Length]);
        return seq.Count();
    }
    
    private void backTrack(string tiles, string curr, bool[] used) {
        for (int i = 0; i < tiles.Length; i++) {
            if (!used[i]) {
                used[i] = true;
                curr += tiles[i];
                seq.Add(curr);
                backTrack(tiles, curr, used);
                curr = curr.Remove(curr.Length - 1);
                used[i] = false;
            }
        }
    }
}
