﻿using System;
namespace StatePattern
{
    /// <summary>
    /// 上下文
    /// </summary>
    public class Context
    {
        private AbstractState state;

        public AbstractState State
        {
            get => state;
            set
            {
                state = value;
                Console.WriteLine($"当前的状态：{state.GetType().Name}");
            }
        }

        public void Request()
        {

        }
    }
}
