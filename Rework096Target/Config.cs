using Exiled;
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.ComponentModel;

namespace AddingTarget
{
    public class Config : IConfig
    {
        [Description("Should plugin work?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Debug?")]
        public bool Debug { get; set; } = false;
        [Description("Broadcast to player, who became SCP096's target")]
        public string AddingTargetBroadcast { get; set; } = "ВЫ ЦЕЛЬ SCP096";
        
    }
}
