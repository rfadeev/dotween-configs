using UnityEngine;
using DG.Tweening;

namespace DOTweenConfigs
{
    public static partial class DOTweenExtensions
    {
        public static Tweener DOAnchorMin(this RectTransform target, Move2DTweenConfig c)
        {
            return target.DOAnchorMin(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOAnchorMax(this RectTransform target, Move2DTweenConfig c)
        {
            return target.DOAnchorMax(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOAnchorPos(this RectTransform target, Move2DTweenConfig c)
        {
            return target.DOAnchorPos(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOAnchorPosX(this RectTransform target, Move1DTweenConfig c)
        {
            return target.DOAnchorPosX(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOAnchorPosY(this RectTransform target, Move1DTweenConfig c)
        {
            return target.DOAnchorPosY(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOAnchorPos3D(this RectTransform target, Move3DTweenConfig c)
        {
            return target.DOAnchorPos3D(c.To, c.Duration, c.Snapping);
        }
    }
}
