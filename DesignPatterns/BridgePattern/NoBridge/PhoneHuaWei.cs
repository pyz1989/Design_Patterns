﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.NoBridge
{
    public class PhoneHuaWei: PhoneBrand
    {
        public PhoneBrand PhoneBrand { get; set; }
        public override void Run()
        {
            throw new NotImplementedException();    
        }
    }
}
