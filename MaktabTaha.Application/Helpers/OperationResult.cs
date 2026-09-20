namespace MaktabTaha.Application.Helpers
{
    public class OperationResult<T>
    {

        public T Data { get; set; }
        public string Message { get; set; }
        public bool IsSuccedded { get; set; }

        public OperationResult()
        {
            IsSuccedded = false;
        }

        public OperationResult<T> Succedded(T data, string message="عملیات با موفقیت انجام شد")
        {
            Data = data;
            Message = message;
            IsSuccedded = true;
            return this;
        }
        public OperationResult<T> Failure(string message)
        {
            Data = default(T);
            Message = message;
            IsSuccedded = false;
            return this;
        }
    }
}
