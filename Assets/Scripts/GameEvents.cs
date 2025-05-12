using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Golf
{
    public static class GameEvents
    {
        public static event System.Action onCollisionStones;//либо это убрать (и всё на что ругается компилятор при его удалении)
        public static event System.Action onStickHit;


        public static void CollisonStonesInvoke(Collision collision)
        { 
            onCollisionStones?.Invoke();
        }

        public static void StickHit()
        {
            onStickHit?.Invoke();
        }

    }
}