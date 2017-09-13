// Definition for singly-linked list:
// template<typename T>
// struct ListNode {
//   ListNode(const T &v) : value(v), next(nullptr) {}
//   T value;
//   ListNode *next;
// };
//

ListNode<int> * mergeTwoLinkedLists(ListNode<int> * l1, ListNode<int> * l2) {
        ListNode <int >result (0), *p = &result;
        while (l1 || l2){
                if (!l1 || l2 && l1->value > l2->value){
                        p = p->next = l2;
                        l2 = l2->next;
                }else{
                        p = p->next = l1;
                        l1 = l1->next;
                }
        }
        return result.next;
}
