namespace UserMgtConsoleApp

{
    public class UserNode<T>
    {
        public T ValueFName { get; set; }
        public T ValueLName { get; set; }
        public T ValueEmail { get; set; }
        

        public UserNode(T value)
        {
            this.Value = value;
        }

        public UserNode(T firstname, T lastName, T email)
        {
            this.ValueFName = firstname;
            this.ValueLName = lastName;
            this.ValueEmail = email;
        }
        
        public T Value { get; set; }
        public UserNode<T> Next { get; set; }
    }
}