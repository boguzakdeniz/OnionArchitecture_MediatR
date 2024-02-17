namespace ProductApp.Application.Wrappers
{
    internal class PagedResponse<T> : ServiceResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public PagedResponse()
        {
            PageNumber = 1;
            PageSize = 10;
        }
        public PagedResponse(T value, int pageNumber,int pageSize) : base(value)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
