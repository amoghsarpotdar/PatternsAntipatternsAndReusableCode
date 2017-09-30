namespace TheNullObjectPattern
{
    class User : IUser
    {
        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName; 
            } 
        }
    }
}
