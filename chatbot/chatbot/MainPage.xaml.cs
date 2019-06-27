using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace chatbot
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            ChatBotViewModel vm;

            InitializeComponent();


            BindingContext = vm = new ChatBotViewModel();


            vm.Messages.CollectionChanged += (sender, e) =>
            {
                var target = vm.Messages[vm.Messages.Count - 1];
                MessagesList.ScrollTo(target, ScrollToPosition.End, true);
            };
        }
    }
}
