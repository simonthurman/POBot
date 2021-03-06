﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.AI.Luis;
using Microsoft.Bot.Builder.AI.QnA;

namespace POBot
{
    interface IBotService
    {
        LuisRecognizer Dispatch { get; }

        QnAMaker POHowToQnA { get; }
    }
}
