public class MyHashSet {
    private List<int> myMap;
    public MyHashSet() {
        myMap = new List<int>();
    }
    
    public void Add(int key) {
        if (!myMap.Contains(key))
        {
            myMap.Add(key);
        }
    }
    
    public void Remove(int key) {
        if (myMap.Contains(key))
        {
            myMap.Remove(key);
        }
    }
    
    public bool Contains(int key) {
        return myMap.Contains(key);
    }
}