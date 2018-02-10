using UnityEngine;
using DG.Tweening;

namespace DOTweenConfigs
{
    public static partial class DOTweenExtensions
    {
        public static Tweener DOMove(this Transform target, Move3DTweenConfig c)
        {
            return target.DOMove(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOMoveX(this Transform target, MoveAxisTweenConfig c)
        {
            return target.DOMoveX(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOMoveY(this Transform target, MoveAxisTweenConfig c)
        {
            return target.DOMoveY(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOMoveZ(this Transform target, MoveAxisTweenConfig c)
        {
            return target.DOMoveZ(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOLocalMove(this Transform target, Move3DTweenConfig c)
        {
            return target.DOLocalMove(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOLocalMoveX(this Transform target, MoveAxisTweenConfig c)
        {
            return target.DOLocalMoveX(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOLocalMoveY(this Transform target, MoveAxisTweenConfig c)
        {
            return target.DOLocalMoveY(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOLocalMoveZ(this Transform target, MoveAxisTweenConfig c)
        {
            return target.DOLocalMoveZ(c.To, c.Duration, c.Snapping);
        }
    }
}
