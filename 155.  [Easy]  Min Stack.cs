public class MinStack {

    /** initialize your data structure here. */
    public List<int> ds;
    public List<int> min;
    public MinStack() {
        ds = new List<int>();
        min = new List<int>();
    }
    
    public void Push(int x) {
        ds.Add(x);
        if(!min.Any()){
            min.Add(x);
        }else{
            if(min[min.Count-1] >= x){
                min.Add(x);
            }
        }
    }
    
    public void Pop() {
        if(ds[ds.Count - 1] == min[min.Count - 1]){
            min.RemoveAt(min.Count-1);
        }
        ds.RemoveAt(ds.Count-1);
    }
    
    public int Top() {
        return ds[ds.Count - 1];
    }
    
    public int GetMin() {
        return min[min.Count - 1];
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */