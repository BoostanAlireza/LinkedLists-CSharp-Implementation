using System;

namespace LinkedLists{
    public class LinkedList {
        private Node? first;
        private Node? last;
        private int size;

        // AddFirst
        public void AddFirst(int value) {
            var node = new Node(value);

            if (first == null) 
            {
                first = node;
                last = node;
            }
            else 
            {
                node.next = first;
                first = node;
            }
            size++;
        }

        // Addlast
        public void AddLast(int value) {
            var node = new Node(value);

            if (first == null)
            {
                first = node;
                last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
            size++;
        }

        // deleteFirst
        public void DeleteFirst() {
            if (first == null) {
                throw new InvalidOperationException("The list is empty");
            }

            if (first == last) 
            {
                first = null;
                last = null;
            }

            else 
            {
                var second = first.next;  // it could be done using only first = first.next; 
                first.next = null;  //but we need to set the first node's next to null to avoid memory leak   
                first = second; //  in languages without garbage collection, e.g. C and C++
            }
            size--;
        }

        // deleteLast
        public void DeleteLast() {
            if (first == null) {
                throw new InvalidOperationException("The list is empty");
            }

            if (first == last) {
                first = null;
                last = null;
            }

            else 
            {
                var current = first;
                while (current?.next != last) {
                    current = current.next;
                }
                last = current;
                current.next = null;
            }
            size--;
        }


        // indexOf
        public int IndexOf(int value) {
            var current = first;
            var index = 0;

            while (current != null) {
                if (current.value == value)
                    return index;
                
                current = current.next;
                index++;
            }
            return -1;
        }

        // contains
        public bool Contains(int value) {
            return IndexOf(value) != -1;
                
            // var current = first;
            
            // while (current != null) {
            //     if (current.value == value)
            //         return true;
            //     current = current.next;
            // }
            // return false;
        }

        // size
        public int Size() {
            return size;
        }

        // print
        public void Print()
        {
            var current = first;

            Console.Write("[");
            while (current != null)
            {
                Console.Write(current.value);

                if (current.next != null)
                    Console.Write(", ");

                current = current.next;
            }
            Console.WriteLine("]");
        }

        // convert to array
        public int[] ToArray() {
            int[] array = new int[size];
            var current = first;
            var index = 0;
            while (current != null) {
                array[index++] = current.value;
                current = current.next;
            }
            return array;
        }

        // reverse
        public void reverse() {
            if (first == null) {
                throw new InvalidOperationException("The list is Empty.");
            }
            var previous = first;
            var current = first.next;
            while(current != null) {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            last = first;
            last.next = null;
            first = previous;
        }
    
    public int getKthFromTheEnd(int k) {
        if (k <= 0){
            throw new ArgumentException("k must be greater than 0.");
        }
        if (first == null) {
                throw new InvalidOperationException("The list is Empty.");
        }
        var pointer1 = first;
        var pointer2 = first;
        for (int i = 0; i < k; i++) {
            pointer1 = pointer1.next;
        }
        while(pointer1 != null) {
            pointer1 = pointer1.next;
            pointer2 = pointer2.next;
        }
        return pointer2.value;
    }

    // fast/slow pointer technique
    public void printMiddle() {
        if (first == null) {
            throw new InvalidOperationException("The list is Empty.");
        }
        var slow = first;
        var fast = first;
        Node prevSlow = null;

        while(fast != null && fast.next != null) {
            prevSlow = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        if (fast == null) {
            // Even number of nodes -> two middles
            Console.WriteLine($"{prevSlow.value} {slow.value}");
        }
        else {
            // Odd number of nodes -> one middle
            Console.WriteLine($"{slow.value}");
        }
    }

    // Floyd’s Cycle Detection Algorithm
    public bool hasLoop() {
        var slow = first;
        var fast = first;

        while(fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast) 
                return true;
        }
        return false;
    }
    }
}