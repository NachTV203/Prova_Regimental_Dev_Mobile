using SQLite;
using appProvaA1Caneta.Model;

namespace appProvaA1Caneta.DAL
{
    public class crudSQLite
    {
        readonly SQLiteAsyncConnection _conexao;

        public crudSQLite(string dbPath)
        {
            _conexao = new SQLiteAsyncConnection(dbPath);
            _conexao.CreateTableAsync<Caneta>().Wait();
        }

        public Task<int> InsertCaneta(Caneta caneta)
        {
            return _conexao.InsertAsync(caneta);
        }

        public Task<List<Caneta>> GetCanetas()
        {
            return _conexao.Table<Caneta>().ToListAsync();
        }

        public Task<int> UpdateCaneta(Caneta caneta)
        {
            return _conexao.UpdateAsync(caneta);
        }

        public Task<int> DeleteCaneta(int id)
        {
            return _conexao.Table<Caneta>().DeleteAsync(c => c.canID == id);
        }
    }
}