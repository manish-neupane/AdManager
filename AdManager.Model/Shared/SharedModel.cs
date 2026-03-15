namespace AdManager.Model.Shared;

public class MvParamReqOption<T>
{
    public string? SearchText { get; set; }
    public string? Operator { get; set; }
    public int? Offset { get; set; }
    public int? PageSize { get; set; }
    public string? SortBy { get; set; }
    public string? SortOrder { get; set; }
    public T? Filter { get; set; }
}

public class MvGridConfig<T>
{
    public required List<T> Data { get; set; }
    public required int TotalCount { get; set; }
}

public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }
    public object? Errors { get; set; }
}

public class MvSpError
{
    public string? Type { get; set; }
    public string? Message { get; set; }
}