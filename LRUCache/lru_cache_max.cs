public class Cache
{
    public int key {set; get;}
    public int value {set; get;}
    public Cache(int key, int value)
    {
        this.key = key;
        this.value = value;
    }
}

public class LRUCache {

    private int capacity;
    private Dictionary<int, Cache> dic;
    private LinkedList<Cache> cacheList;
          
    public LRUCache(int capacity) {
        this.capacity = capacity;
        dic = new Dictionary<int, Cache>();
        cacheList = new LinkedList<Cache>();
    }
    
    public int Get(int key) {
        if(!dic.ContainsKey(key))
            return -1;
        
        Cache currCache = dic[key];
        cacheList.Remove(currCache);
        cacheList.AddFirst(currCache);
        return dic[key].value;
    }
    
    public void Put(int key, int value) {
        if(dic.ContainsKey(key))
        {
            dic[key].value = value; 
                     
            cacheList.Remove(dic[key]);
            cacheList.AddFirst(dic[key]);
        }
        else
        {
            Cache newCache = new Cache(key, value);
            dic.Add(key, newCache);
            cacheList.AddFirst(newCache);
        }
        
        if(dic.Count > capacity)
        {
            dic.Remove(cacheList.Last.Value.key);
            cacheList.RemoveLast();         
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
