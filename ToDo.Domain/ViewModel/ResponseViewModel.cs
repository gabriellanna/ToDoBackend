namespace ToDo.Domain.ViewModel
{
    public class ResponseViewModel
    {
        public ResponseViewModel(bool sucess, string? message, object? data)
        {
            Sucess = sucess;
            Message = message;
            Data = data;
        }
        public bool Sucess { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
    }

    public class ResponseViewModel<T>
    {
        public ResponseViewModel(bool sucess, string? message, T? data)
        {
            Sucess = sucess;
            Message = message;
            Data = data;
        }
        public bool Sucess { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
    }
}