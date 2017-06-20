using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AzureDbOperationSample
{
    public class NameListManager
    {
        static NameListManager defaultInstance = new NameListManager();
        MobileServiceClient client;
        IMobileServiceTable<NameList> nameListTable;

        public NameListManager()
        {
            var client = new MobileServiceClient("URL");
            nameListTable = client.GetTable<NameList>();
        }

        public static NameListManager DefaultManager
        {
            get
            {
                return defaultInstance;
            }
            private set
            {
                defaultInstance = value;
            }
        }

        public async Task<List<NameList>> GetIdAsync(string name)
        {
            List<NameList> items = await nameListTable
            .Where(nameListTable => nameListTable.Name == name)
            .ToListAsync();

            return items;
        }

        public async Task SaveTaskAsync(NameList item)
        {
            try
            {
                if (item.Id == null)
                {
                    await nameListTable.InsertAsync(item);
                }
                else
                {
                    await nameListTable.UpdateAsync(item);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}