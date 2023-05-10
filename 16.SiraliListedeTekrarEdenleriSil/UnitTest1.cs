using System.Runtime.CompilerServices;

namespace _16.SiraliListedeTekrarEdenleriSil
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            ListNode list1 = new ListNode(1, new ListNode(1, new ListNode(2)));
            ListNode expected1 = new ListNode(1, new ListNode(2));

            //Act
            var result1 = DeleteDuplicates(list1);

            //Assert
            Assert.True(AreListEqual(expected1, result1));
        }   
        
        private bool AreListEqual(ListNode list1, ListNode list2)
        {
            while(list1 != null && list2 != null)
            {
                if (list1.val != list2.val) return false;

                list1 = list1.next; //1 1 2 
                list2 = list2.next;
            }

            return list1 == null && list2 == null;
        }
                
        public ListNode DeleteDuplicates(ListNode head)
        {

            ListNode result = head;

            while(head.next != null)
            {
                if(head.val == head.next.val) // 1 1 2 3
                {
                    head.next = head.next.next;
                }
                else
                {
                    head = head.next;
                }
            }

            return result;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) // 1 1 2
            {
                this.val = val;
                this.next = next;
            }
        }        
    }
}