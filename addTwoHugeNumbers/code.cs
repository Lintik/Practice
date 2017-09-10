// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> addTwoHugeNumbers(ListNode<int> a, ListNode<int> b) {
    ListNode<int> s = new ListNode<int>();
    Stack<int> c = new Stack<int>();
    Stack<int> d = new Stack<int>();
    Stack<int> e = new Stack<int>();
    
    int m = 0;
    int n = 0;
    int o = 0;
    
    while(a != null){
        int t = a.value;
        m = Math.Max(m, t.ToString().Length);
        c.Push(a.value);
        a = a.next;
    }
    while(b != null){
        int t = b.value;
        n = Math.Max(n, t.ToString().Length);
        d.Push(b.value);
        b = b.next;
    }
    o = Math.Max(m,n);
    o = Convert.ToInt32(Math.Pow(10,o));
    int r = 0;
    while(c.Count != 0 && d.Count != 0){
        int a1 = c.Pop();
        int a2 = d.Pop();
        e.Push((a1 + a2 + r) % o);
        r = (a1 + a2 + r) / o;
    }
    while(c.Count != 0 || d.Count != 0){
        if(c.Count == 0){
            int a1 = d.Pop();
            e.Push((a1 + r) % o);
            r = (a1 + r) / o;
        }
        else{
            int a1 = c.Pop();
            e.Push((a1 + r) % o);
            r = (a1 + r) / o;
        }
    }
    if(r > 0)
        e.Push(r);
    var s1 = s;
    while(e.Count > 0){
        s.value = e.Pop();
        if(e.Count > 0){
            s.next = new ListNode<int>();
            s = s.next;
        }
    }
    return s1;
}
