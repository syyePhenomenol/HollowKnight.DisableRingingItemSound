using Modding;
using UnityEngine;

namespace HollowKnight.DisableRingingItemSound
{
    public class DisableRingingItemSound : Mod
    {
        public override string GetVersion() => "1.0.0";

        public override void Initialize()
        {
            On.PlayMakerFSM.OnEnable += PlayMakerFSM_OnEnable;
        }

        private void PlayMakerFSM_OnEnable(On.PlayMakerFSM.orig_OnEnable orig, PlayMakerFSM self)
        {
            orig(self);

            if (self.FsmName == "Shiny Control")
            {
                self.gameObject.GetComponent<AudioSource>()?.Stop();
            }
        }
    }
}
