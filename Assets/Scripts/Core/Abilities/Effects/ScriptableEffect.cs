#pragma warning disable 0649

using UnityEngine;

namespace MonsterRPG
{
    [CreateAssetMenu(fileName = "new-ability-effect", menuName = "ScriptableObjects/Effects/Effect")]
    public class ScriptableEffect : ScriptableObject
    {
        [SerializeField]
        private Container container;

        public Container Container { get { return container; } }
    }
}