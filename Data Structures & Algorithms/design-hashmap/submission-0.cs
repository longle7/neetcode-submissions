public class MyHashMap
{
    private int[] myMap;
    public MyHashMap()
    {
        myMap = new int[1000001];
        Array.Fill(myMap, -1);
    }
    public void Put(int key, int value)
    {
        myMap[key] = value; 
    }

    public int Get(int key)
    {
        return myMap[key];
    }

    public void Remove(int key)
    {
        myMap[key] = -1;
    }
}