﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlightUpdateType
    {
        delay = 1,
        gate_change,
        cancellation
    }
}
