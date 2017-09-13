# Definition for singly-linked list:
# class ListNode(object):
#   def __init__(self, x):
#     self.value = x
#     self.next = None
#
def mergeTwoLinkedLists(A, B):
    cur = ans = ListNode(None)
    
    while A and B:
        if A.value <= B.value:
            cur.next = cur = ListNode(A.value)
            A = A.next
        else:
            cur.next = cur = ListNode(B.value)
            B = B.next
    
    cur.next = A or B
    return ans.next
