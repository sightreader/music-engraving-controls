namespace Manufaktura.Orm.Linq
{
    public static class RepositoryExtensions
    {
        public static DbRepositoryQuery<T> Table<T>(this DbRepository repository) where T : new()
        {
            return new DbRepositoryQuery<T>(repository);
        }
    }
}