namespace Wiedpug.API.Model
{
    public class ApiResult
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
