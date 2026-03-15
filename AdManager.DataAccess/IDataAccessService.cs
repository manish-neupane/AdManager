using System.Data;

namespace AdManager.DataAccess
{
    public interface IDataAccessService
    {
        Task<IDbConnection> GetConnection();

        Task<string> RetrievalProcedure(string storedProcedure, string json);

        Task<string> ActionProcedure(string storedProcedure, string json);
    }
}
