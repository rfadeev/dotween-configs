#if DOTWEEN_SPRITE_MODULE_ENABLED

using UnityEngine;
using DG.Tweening;

namespace DOTweenConfigs
{
    public static partial class DOTweenExtensions
    {
        public static Tweener DOColor(this SpriteRenderer target, ColorTweenConfig c)
        {
            return target.DOColor(c.To, c.Duration);
        }
    }
}

#endif
