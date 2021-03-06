Linked List Merge
Challenge
Write a method to zipper/shuffle merge two linked lists together and return the newly-merged linked list

Approach & Efficiency
This solution closely follows the algorithm described here and diverges from the approach shown in the whiteboard image below. The whiteboard version modifies the original linked list arguments, while the implemented solution creates an entirely new list.

Time Complexity = O(n): We must traverse and count all n nodes of the shorter array
Space Compexity = O(1): No "containers" relative in size to n are needed. Both linked lists merged into the resulting list end up modified, however.

![ll_merge](../../../assets/ll_merge.jpg)