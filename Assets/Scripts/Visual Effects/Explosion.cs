using UnityEngine;

namespace MonsterRPG
{
    public sealed class Explosion : Cinematograph
    {
        private void OnParticleSystemStopped()
        {
            Complete();
        }
    }
}
