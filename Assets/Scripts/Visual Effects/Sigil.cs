using UnityEngine;

namespace MonsterRPG
{
    public sealed class Sigil : Cinematograph
    {
        private void OnParticleSystemStopped()
        {
            Complete();
        }
    }
}
