namespace DataLibrary
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U Parameters, string conectionString);
        Task SaveData<T>(string sql, T Parameters, string conectionString);
    }
}