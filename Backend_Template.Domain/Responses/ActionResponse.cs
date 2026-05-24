namespace Backend_Template.Domain.Responses
{
    public class ActionResponse<T>(int statusCode, bool success, string? message = null, T? data = default)
    {
        public const int StatusOk = 200;
        public const int StatusCreated = 201;
        public const int StatusBadRequest = 400;
        public const int StatusUnauthorized = 401;
        public const int StatusNotFound = 404;
        public const int StatusInternalServerError = 500;

        public int StatusCode { get; set; } = statusCode;
        public bool Success { get; set; } = success;
        public string? Message { get; set; } = message;
        public T? Data { get; set; } = data;

        public bool WasSuccess
        {
            get => Success;
            set => Success = value;
        }

        public T? Result
        {
            get => Data;
            set => Data = value;
        }

        public static ActionResponse<T> Ok(T? data = default, string? message = null)
            => new(StatusOk, true, message, data);

        public static ActionResponse<T> Created(T? data = default, string? message = null)
            => new(StatusCreated, true, message, data);

        public static ActionResponse<T> BadRequest(string? message = null, T? data = default)
            => new(StatusBadRequest, false, message, data);

        public static ActionResponse<T> Unauthorized(string? message = null, T? data = default)
            => new(StatusUnauthorized, false, message, data);

        public static ActionResponse<T> NotFound(string? message = null, T? data = default)
            => new(StatusNotFound, false, message, data);

        public static ActionResponse<T> InternalServerError(string? message = null, T? data = default)
            => new(StatusInternalServerError, false, message, data);

        public static ActionResponse<T> Create(int statusCode, bool success, T? data = default, string? message = null)
            => new(statusCode, success, message, data);
    }
}
