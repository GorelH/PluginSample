﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Abstractions;

namespace OutOfProcessPluginHost
{
    public class PluginData : IPluginData
    {
        public string Message { get; set; }
    }

}
