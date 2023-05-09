using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DogFactsSamples.Data
{
    public class FactDataDatabase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);   
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public FactDataDatabase()
        {
            
        }

        async Task InitializeAsync()
        {
            if(!initialized)
            {
                if(!Database.TableMappings.Any(m => m.MappedType.Name == typeof(JeffFactData).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(JeffFactData)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<JeffFactData>> GetItemsAsync()
        {
            return Database.Table<JeffFactData>().ToListAsync();
        }

        public Task<JeffFactData> GetItemAsync(int id)
        {
            return Database.Table<JeffFactData>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(JeffFactData item)
        {
            if(item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> InsertList(IEnumerable<JeffFactData> items)
        {
            return Database.InsertAllAsync(items);
        }

        public Task<int> DeleteItemAsync(JeffFactData item)
        {
            return Database.DeleteAsync(item);
        }

        public Task<int> ClearAllAsync()
        {
            return Database.DeleteAllAsync<JeffFactData>();
        }
    }
}
