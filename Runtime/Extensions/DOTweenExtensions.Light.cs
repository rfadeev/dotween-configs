using UnityEngine;
using DG.Tweening;

namespace DOTweenConfigs
{
    public static partial class DOTweenExtensions
    {
        public static Tweener DOColor(this Light target, ColorTweenConfig c)
        {
            return target.DOColor(c.To, c.Duration);
        }
    }
}
