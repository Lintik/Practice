// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> mergeTwoLinkedLists(ListNode<int> l1, ListNode<int> l2) {
    if(l1 == null) return l2;
    if(l2 == null) return l1;
    
    if(l1.value < l2.value){
        l1.next = mergeTwoLinkedLists(l1.next, l2);
        return l1;
    }
    else{
        l2.next = mergeTwoLinkedLists(l2.next, l1);
        return l2;
    }
}
