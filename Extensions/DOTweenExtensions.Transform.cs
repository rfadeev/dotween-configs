using UnityEngine;
using DG.Tweening;

namespace DOTweenConfigs
{
    public static partial class DOTweenExtensions
    {
        public static Tweener DOMove(this Transform target, Position3DTweenConfig c)
        {
            return target.DOMove(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOMoveX(this Transform target, Position1DTweenConfig c)
        {
            return target.DOMoveX(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOMoveY(this Transform target, Position1DTweenConfig c)
        {
            return target.DOMoveY(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOMoveZ(this Transform target, Position1DTweenConfig c)
        {
            return target.DOMoveZ(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOLocalMove(this Transform target, Position3DTweenConfig c)
        {
            return target.DOLocalMove(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOLocalMoveX(this Transform target, Position1DTweenConfig c)
        {
            return target.DOLocalMoveX(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOLocalMoveY(this Transform target, Position1DTweenConfig c)
        {
            return target.DOLocalMoveY(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOLocalMoveZ(this Transform target, Position1DTweenConfig c)
        {
            return target.DOLocalMoveZ(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOScale(this Transform target, Scale3DTweenConfig c)
        {
            return target.DOScale(c.To, c.Duration);
        }

        public static Tweener DOScaleX(this Transform target, Scale1DTweenConfig c)
        {
            return target.DOScaleX(c.To, c.Duration);
        }

        public static Tweener DOScaleY(this Transform target, Scale1DTweenConfig c)
        {
            return target.DOScaleY(c.To, c.Duration);
        }

        public static Tweener DOScaleZ(this Transform target, Scale1DTweenConfig c)
        {
            return target.DOScaleZ(c.To, c.Duration);
        }
    }
}
