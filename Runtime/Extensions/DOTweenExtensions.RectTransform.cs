#if DOTWEEN_UI_MODULE_ENABLED

using UnityEngine;
using DG.Tweening;

namespace DOTweenConfigs
{
    public static partial class DOTweenExtensions
    {
        public static Tweener DOAnchorMin(this RectTransform target, Position2DTweenConfig c)
        {
            return target.DOAnchorMin(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOAnchorMax(this RectTransform target, Position2DTweenConfig c)
        {
            return target.DOAnchorMax(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOAnchorPos(this RectTransform target, Position2DTweenConfig c)
        {
            return target.DOAnchorPos(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOAnchorPosX(this RectTransform target, Position1DTweenConfig c)
        {
            return target.DOAnchorPosX(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOAnchorPosY(this RectTransform target, Position1DTweenConfig c)
        {
            return target.DOAnchorPosY(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOAnchorPos3D(this RectTransform target, Position3DTweenConfig c)
        {
            return target.DOAnchorPos3D(c.To, c.Duration, c.Snapping);
        }

        public static Tweener DOShakeAnchorPos(this RectTransform target, SnapShakeTweenConfig c)
        {
            return target.DOShakeAnchorPos(c.Duration, c.Strength, c.Vibrato, c.Randomness, c.Snapping, c.FadeOut);
        }

        public static Tweener DOShakeAnchorPos(this RectTransform target, SnapShake2DTweenConfig c)
        {
            return target.DOShakeAnchorPos(c.Duration, c.Strength, c.Vibrato, c.Randomness, c.Snapping, c.FadeOut);
        }
    }
}

#endif
