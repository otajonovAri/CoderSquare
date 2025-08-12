namespace CoderSquare.Application.Responses;

public record ApiResult<T>
    (string Message = null!, bool Success = false , T Date = default!);