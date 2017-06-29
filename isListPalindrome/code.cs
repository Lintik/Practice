// Definition for singly-linked list:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
bool isListPalindrome(ListNode<int> l) {
    if(l == null) return true;
    List<int> m = new List<int>();
    var n = l;
    while(n.next != null){
        m.Add(n.value);
        n = n.next;
    }
    m.Add(n.value);
    if(m.Count == 0 || m.Count == 1)
        return true;
    
    int[] k = m.ToArray();
    for(int i = 0; i < k.Length/2;i++)
        if(k[i] != k[k.Length - i - 1])
            return false;
    return true;
    
}
