using UnityEngine;

namespace MonsterRPG
{
    public sealed class Sword : Cinematograph
    {
        private void OnParticleSystemStopped()
        {
            Complete();
        }
    }
}
