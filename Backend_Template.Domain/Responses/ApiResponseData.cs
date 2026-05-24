namespace Backend_Template.Domain.Responses
{
    public class ApiResponseData<T> : ApiResponse
    {
        public T? Data { get; set; }
    }
}