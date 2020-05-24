public class Solution {
    
    public int fivesCount = 0;
    public int tensCount = 0;
    
    public bool LemonadeChange(int[] bills) {
        bool canGiveChange = true;
        for(int i = 0; i < bills.Length && canGiveChange;  i++) {
            if (bills[i] == 5)
            {
                fivesCount++;
            }
            else if (bills[i] == 10 && fivesCount != 0) 
            {
                fivesCount--;
                tensCount++;
            }
            else if (bills[i] == 20) {
                if (fivesCount >= 3 && tensCount == 0) 
                {
                    fivesCount -= 3;    
                }
                else if (fivesCount != 0 && tensCount != 0) 
                {
                    fivesCount--;
                    tensCount--;
                }
                else 
                {
                    canGiveChange = false;    
                }
            }
            else 
            {
                canGiveChange = false;
            }
        }
        
        return canGiveChange;
    }
}
