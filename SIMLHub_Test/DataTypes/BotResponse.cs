﻿using ICAN.SIC.Abstractions.IMessageVariants;
using Syn.Bot.Siml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICAN.SIC.Plugin.SIMLHub.DataTypes
{
    public class BotResult : IBotResult
    {
        ChatResult chatResult;
        IUserResponse userResponse;

        public BotResult(ChatResult result, IUserResponse userResponse)
        {
            this.chatResult = result;
            this.userResponse = userResponse;
        }

        public Syn.Bot.Siml.ChatResult ChatResult
        {
            get { return chatResult; }
        }

        public string Text
        {
            get { return chatResult.BotMessage; }
        }

        public IUserResponse UserResponse
        {
            get { return userResponse; }
        }
    }
}
