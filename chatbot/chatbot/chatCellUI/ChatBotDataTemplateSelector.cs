namespace chatbot.chatCellUI
{
    using chatbot.Models;
    using Xamarin.Forms;


    public class ChatBotDataTemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate botDataTemplate;
        private readonly DataTemplate userDataTemplate;

        public ChatBotDataTemplateSelector()
        {
            this.botDataTemplate = new DataTemplate(typeof(BotCell));
            this.userDataTemplate = new DataTemplate(typeof(UserCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = item as ChatMessage;
            if (message == null)
                return null;
            return message.IsIncoming ? this.botDataTemplate : this.userDataTemplate;
        }
    }
}
