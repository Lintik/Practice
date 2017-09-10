// Definition for singly-linked list:
// template<typename T>
// struct ListNode {
//   ListNode(const T &v) : value(v), next(nullptr) {}
//   T value;
//   ListNode *next;
// };
//

ListNode<int>* reverse(ListNode<int>* l) {
    ListNode<int>* prev = nullptr;
    while (l) {
        ListNode<int>* next = l->next;
        l->next = prev;
        prev = l;
        l = next;
    }
    return prev;
}
ListNode<int>* addTwoHugeNumbers(ListNode<int>* a, ListNode<int>* b) {
    const int maxValue = 10'000;
    a = reverse(a);
    b = reverse(b);
    ListNode<int>* result;
    int carry = 0;
    while (a || b || carry) {
        int sum = carry;
        if (a) {
            sum += a->value;
            a = a->next;
        }
        if (b) {
            sum += b->value;
            b = b->next;
        }
        carry = sum / maxValue;
        sum %= maxValue;
        ListNode<int>* start = new ListNode<int>(sum);
        start->next = result;
        result = start;
    }
    return result;
}
