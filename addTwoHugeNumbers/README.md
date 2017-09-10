You're given 2 huge integers represented by linked lists. Each linked list element is a number from 0 to 9999 that represents a number with exactly 4 digits. The represented number might have leading zeros. Your task is to add up these huge integers and return the result in the same format.

__Example__

* For a = [9876, 5432, 1999] and b = [1, 8001], the output should be <br />addTwoHugeNumbers(a, b) = [9876, 5434, 0].<br /><br />Explanation: 987654321999 + 18001 = 987654340000.

* For a = [123, 4, 5] and b = [100, 100, 100], the output should be<br />addTwoHugeNumbers(a, b) = [223, 104, 105].<br /><br />Explanation: 12300040005 + 10001000100 = 22301040105.

__Input/Output__

* __[time limit] 3000ms (cs)__
* __[input] linkedlist.integer a__<br /><br />The first number, without its leading zeros.<br /><br />Guaranteed constraints:<br />0 ≤ a size ≤ 104,<br />0 ≤ element value ≤ 9999.

* __[input] linkedlist.integer b__<br /><br />The second number, without its leading zeros.<br /><br />Guaranteed constraints:<br />0 ≤ b size ≤ 104,<br />0 ≤ element value ≤ 9999.

* __[output] linkedlist.integer__<br /><br />The result of adding a and b together, returned without leading zeros in the same format.
