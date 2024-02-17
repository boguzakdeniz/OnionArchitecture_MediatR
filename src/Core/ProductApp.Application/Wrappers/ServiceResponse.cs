namespace ProductApp.Application.Wrappers
{
    public class ServiceResponse<T> : BaseResponse
    {
        public T Value { get; set; }
        public ServiceResponse()
        {
            
        }
        public ServiceResponse(T value)
        {
            Value = value;
        }
    }
}
