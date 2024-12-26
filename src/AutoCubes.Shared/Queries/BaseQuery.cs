namespace AutoCubes.Shared.Queries
{
    public class BaseQuery<T> : IQuery<T>
    {
        public bool IsSuccess { get; set; }
    }
}
