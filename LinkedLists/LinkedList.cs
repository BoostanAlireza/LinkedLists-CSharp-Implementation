namespace LinkedLists{
    public class LinkedList {
        private Node first;
        private Node last;
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
                while (current.next != last) {
                    current = current.next;
                }
                last = current;
                current.next = null;
            }
            seize--;
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
            return IndexOf(value) != -1
                
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

        public void Print() {
            var current = first;

            Console.Write("[");
            while (current != null) {
                Console.Write(current.value);
                if (current.next != null) {
                    Console.Write(", ");

                current = current.next;
                }
                Console.Write("]");
            }
        }
}