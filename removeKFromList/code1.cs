ListNode<int> removeKFromList(ListNode<int> l, int k) {
    List<int> a = new List<int>();
    while(true){
        if (l == null) break;
        if (l.value != k) a.Add(l.value);
        l = l.next;
    }
    ListNode<int> r = null;
    ListNode<int> t = null;
    for (int i = a.Count-1; i >=0; i--){
        r = t;
        t = new ListNode<int>();
        t.value = a[i];
        t.next = r;
    }
    return t;
}
