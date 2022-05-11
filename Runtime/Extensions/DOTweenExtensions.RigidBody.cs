#if DOTWEEN_PHYSICS_MODULE_ENABLED

using UnityEngine;
using DG.Tweening;

namespace DOTweenConfigs
{
    public static partial class DOTweenExtensions
    {
        public static Tweener DOMove(this Rigidbody target, Position3DTweenConfig c)
        {
            return target.DOMove(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOMoveX(this Rigidbody target, Position1DTweenConfig c)
        {
            return target.DOMoveX(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOMoveY(this Rigidbody target, Position1DTweenConfig c)
        {
            return target.DOMoveY(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOMoveZ(this Rigidbody target, Position1DTweenConfig c)
        {
            return target.DOMoveZ(c.To, c.Duration, c.Snapping);
        }
    }
}

#endif
