﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Syncfusion.Maui.Chat;
using Syncfusion.Maui.Picker;

namespace ChatMaui.ViewModels
{
    public class ChatViewModel
    {

        public Author CurrentUser { get; set; }
        public Author SecondUser { get; set; }
        public ObservableCollection<object> Message { get; set; }
        public ChatViewModel()
        {
            Message = new ObservableCollection<object>();
            CurrentUser = new Author() { Name = "nami", Avatar = "dotnet_bot.png" };
            SecondUser = new Author() { Name = "mohan", Avatar = "dotnet_bot.png" };

            GenerateMassages();
        }

        private void GenerateMassages()
        {
            Message.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "Hi Guys, Good Morning! I'm very delighted to share with you the news that our team is going to do."
            });
            Message.Add(new TextMessage()
            {
                Author = SecondUser,
                Text = "Hi Guys, Good Morning! I'm very delighted to share with you the news that our team is going to do."
            });
            Message.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "Hi Guys, Good Morning! I'm very delighted to share with you the news that our team is going to do."
            });
            Message.Add(new TextMessage()
            {
                Author = SecondUser,
                Text = "noe I'm very delighted to share with you the news that our team is going to do."
            }); Message.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "noe I'm very delighted to share with you the news that our team is going to do."
            });

            Message.Add(new TextMessage()
            {
                Author = SecondUser,
                Text = "Nice to meet You Dear"
            });

        }
    }
}
