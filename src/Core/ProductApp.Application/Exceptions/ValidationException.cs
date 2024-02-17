namespace ProductApp.Application.Exceptions
{
    public class ValidationException(string message) : Exception(message)
    {
        public ValidationException() : this("Validation error occured") { }

        public ValidationException(Exception ex) : this(ex.Message) { }
    }
}
