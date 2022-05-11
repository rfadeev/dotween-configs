#if DOTWEEN_PHYSICS2D_MODULE_ENABLED

using UnityEngine;
using DG.Tweening;

namespace DOTweenConfigs
{
    public static partial class DOTweenExtensions
    {
        public static Tweener DOMove(this Rigidbody2D target, Position3DTweenConfig c)
        {
            return target.DOMove(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOMoveX(this Rigidbody2D target, Position1DTweenConfig c)
        {
            return target.DOMoveX(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOMoveY(this Rigidbody2D target, Position1DTweenConfig c)
        {
            return target.DOMoveY(c.To, c.Duration, c.Snapping);
        }
    }
}

#endif
