using UnityEngine;

namespace MonsterRPG
{
    public class BTTerminate : BTNode
    {
        public override BTState OnUpdate()
        {
            Debug.Log("Terminate AI");

            return BTState.Abort;
        }
    }
}
