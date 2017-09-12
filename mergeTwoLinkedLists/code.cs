// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> mergeTwoLinkedLists(ListNode<int> l1, ListNode<int> l2) {
    if(l1 == null) return l2;
    else if(l2 == null) return l1;
    else{
        var l = l1.value <= l2.value? l1:l2;
        while(l1 != null && l2 != null){
            if(l1.value <= l2.value){
                var t1 = l1.next;
                
                if(t1 != null){
                    while(t1.value <= l2.value){
                        l1 = l1.next;
                        if(t1.next == null) break;
                        else t1 = t1.next;
                    }
                }
                
                var t = l1.next;
                l1.next = l2;
                l2 = t;
            }
            else{
                var t2 = l2.next;
                
                if(t2 != null){
                    while(t2.value < l1.value){
                        l2 = l2.next;
                        if(t2.next == null) break;
                        else t2 = t2.next;
                    }
                }
                
                var t = l2.next;
                l2.next = l1;
                l1 = t;
            }//l2.value is less than l1.value
        }
        return l;
    }
}
