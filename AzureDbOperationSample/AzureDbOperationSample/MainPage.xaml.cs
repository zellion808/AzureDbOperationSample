using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;

namespace AzureDbOperationSample
{
    public partial class MainPage : ContentPage
    {
        NameListManager manager;

        public MainPage()
        {
            InitializeComponent();
            manager = NameListManager.DefaultManager;
        }

        private async void getButton_Clicked(object sender, EventArgs e)
        {
            var id = await manager.GetIdAsync(get.Text);
            
            if (id.Count != 0)
            {
                earnedName.Text = id[0].Id;
            }
            else
            {
                earnedName.Text = "値なし";
            }
        }

        public async void insertButton_Clicked_1(object sender, EventArgs e)
        {
            var name = new NameList { Name = insert.Text };
            await AddItem(name);

            insert.Text = string.Empty;
            insert.Unfocus();
        }

        private void updateButton_Clicked(object sender, EventArgs e)
        {
            // 未実装
        }

        async Task AddItem(NameList item)
        {
            await manager.SaveTaskAsync(item);
        }
    }
}
