using System;
using System.Collections.Generic;

namespace UserMgtConsoleApp
{
    public class UserQueue<T>
    {
        //Head for the first user
        public UserNode<T> Head { get; set; }
        //Tail for the last user
        public UserNode<T> Tail { get; set; }
        //Count the number of user
        public int Count { get; set; }

        //Queue Operations 
        //Enqueue to add user to the queue
        public UserNode<T> Enqueue(T valueFName, T valueLName, T valueEmail)
        {

            //Instantiating the UserNode class
            UserNode<T> node = new UserNode<T>(valueFName, valueLName, valueEmail);

            if (this.Head == null)
            {
                Head = Tail = node;
                this.Count++;
                return node;
            }
            //Tail's next refernce to node and making node the tail
            this.Tail.Next = node;
            this.Tail = node;
            this.Count++;
            return node;
        }

        // Dequeue Method to remove user from the queue
        public T Dequeue()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Queue is Null!");
            }

            T removeUser = this.Head.Value;
            this.Head = this.Head.Next;
            this.Count--;
            return removeUser;

        }

        //Moving from the tail to print all nodes
        public void Print()
        {
            Console.WriteLine("The first user(Head)-> ");
            var temp = Head;
            while (temp != null)
            {
               Console.WriteLine(temp.Value);
               temp = temp.Next;
               Console.Write("-> ");
            }
            Console.Write("End of Queue");
        }
         
    }
}