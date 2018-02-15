using UnityEngine;
using DG.Tweening;

namespace DOTweenConfigs
{
    public static partial class DOTweenExtensions
    {
        public static Tweener DOColor(this Material target, ColorTweenConfig c)
        {
            return target.DOColor(c.To, c.Duration);
        }
    }
}
