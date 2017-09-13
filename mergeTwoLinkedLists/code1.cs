// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> mergeTwoLinkedLists(ListNode<int> l1, ListNode<int> l2) {
    if(l1 == null) return l2;
    if(l2 == null) return l1;
    
    List<int> l = new List<int>();
    ListNode<int> t = new ListNode<int>();
    var s = t;
    while(l1 != null || l2 != null){
        if(l2 == null){
            l.Add(l1.value);
            l1 = l1.next;
        }
        else if(l1 == null){
            l.Add(l2.value);
            l2 = l2.next;
        }
        else{
            if(l1.value <= l2.value){
                l.Add(l1.value);
                l1 = l1.next;
            }
            else{
                l.Add(l2.value);
                l2 = l2.next;
            }
        }
    }
    l.Sort();
    for(int i = 0; i < l.Count; i++){
        t.value = l[i];
        if(i < l.Count - 1){
            t.next = new ListNode<int>();
            t = t.next;
        }
    }
    return s;
}
