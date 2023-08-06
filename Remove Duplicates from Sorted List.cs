//Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

//https://www.youtube.com/watch?v=adsxnLKoR2s

public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {

        ListNode currentItem = head;

        while(currentItem != null && currentItem.next != null)
        {
            if(currentItem.val == currentItem.next.val)
                currentItem.next = currentItem.next.next;

            else
                currentItem = currentItem.next; 

        }
        return head;
    }
}
