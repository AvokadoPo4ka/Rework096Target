using Exiled;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Scp096;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingTarget
{
    public class Plugin : Plugin<Config>
    {
        public override string Prefix => "096Target";
        public override string Name => "AddingSCP096TargetWarn";
        public override string Author => "RABB1T#3072";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(6, 1, 0);

        public static Plugin plugin;

        public override void OnEnabled()
        {
            Log.Debug("I am ready!");
            Exiled.Events.Handlers.Scp096.AddingTarget += OnAddingTarget;
            base.OnEnabled();
        }

        private void OnAddingTarget(AddingTargetEventArgs ev)
        {
            ev.Player.ShowHint(Config.AddingTargetBroadcast, 5f);
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Scp096.AddingTarget -= OnAddingTarget;
            base.OnDisabled();
        }
    }
}
