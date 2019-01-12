namespace ElLib.BLL.Infrastructure
{
    public class OperationDetails
    {
        public bool Successed { get; private set; }
        public string Message { get; private set; }
        public string Property { get; private set; }

        public OperationDetails(bool successed)
        {
            Successed = successed;
            Property = "";
        }

        public OperationDetails(bool successed, string message)
            : this(successed)
        {
            Message = message;
        }

        public OperationDetails(bool successed, string message, string property)
            : this(successed, message)
        {
            Property = property;
        }
    }
}
