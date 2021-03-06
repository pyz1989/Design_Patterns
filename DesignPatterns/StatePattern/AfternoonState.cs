﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 下午
    /// </summary>
    public class AfternoonState: AbstractState
    {
        public override void Handler(Context context)
        {
            
            if (context.Hour >= 14 && context.Hour < 18)
            {
                Console.WriteLine("下午好...");
                return;
            }
            context.State = new EveningState();
            context.Request();
        }
    }
}
