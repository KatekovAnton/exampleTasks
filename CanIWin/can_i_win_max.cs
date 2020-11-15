public class Solution {
	
	Dictionary<string,bool>	memory;
	char[]	state;
	public bool CanIWin(int maxChoosableInteger, int desiredTotal) {
		
		if(desiredTotal <= maxChoosableInteger)	
            return true;
		
		if(desiredTotal > maxChoosableInteger * (1 + maxChoosableInteger) / 2)		                 return false;	
		
		memory = new Dictionary<string,bool>();
		
		state = Enumerable.Repeat('0', maxChoosableInteger + 1).ToArray();		
		return CalculateCanIwin(desiredTotal);
    }
	
	private bool CalculateCanIwin(int desiredTotal)
	{
		var key = new string(state);
		if(memory.ContainsKey(key))		
            return memory[key];
		
		for(int i=1; i<state.Length; i++)
		{
			if(state[i] != '1')
			{
				state[i] = '1';
				if(desiredTotal <= i || !CalculateCanIwin(desiredTotal-i))
				{
					memory[key] = true;
					state[i] = '0';
					return true;
				}
				state[i] = '0';
			}
		}
		
		memory[key] = false;
		return memory[key];
	}
}
