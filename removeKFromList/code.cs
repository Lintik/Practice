ListNode<int> removeKFromList(ListNode<int> l, int k) {
    if(l == null)
        return null;
    
    if(l.value == k){
        var m = l.next;
        l = null;
        return removeKFromList(m, k);
    }
    
    if(l.next == null){
        return l;
    }
    else{
        if(l.next.value == k){
            if(l.next.next == null){
                l.next = null;
                return l;
            }
            else{
                l.next = l.next.next;
                return removeKFromList(l, k);
            }
        }
        else{
            return removeKFromList(l.next, k);
        }
    }
    return l;
}
