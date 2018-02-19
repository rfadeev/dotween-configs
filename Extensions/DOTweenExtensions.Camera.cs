using UnityEngine;
using DG.Tweening;

namespace DOTweenConfigs
{
    public static partial class DOTweenExtensions
    {
        public static Tweener DOColor(this Camera target, ColorTweenConfig c)
        {
            return target.DOColor(c.To, c.Duration);
        }

        public static Tweener DOShakePosition(this Camera target, ShakeTweenConfig c)
        {
            return target.DOShakePosition(c.Duration, c.Strength, c.Vibrato, c.Randomness, c.FadeOut);
        }

        public static Tweener DOShakePosition(this Camera target, Shake3DTweenConfig c)
        {
            return target.DOShakePosition(c.Duration, c.Strength, c.Vibrato, c.Randomness, c.FadeOut);
        }

        public static Tweener DOShakeRotation(this Camera target, ShakeTweenConfig c)
        {
            return target.DOShakeRotation(c.Duration, c.Strength, c.Vibrato, c.Randomness, c.FadeOut);
        }

        public static Tweener DOShakeRotation(this Camera target, Shake3DTweenConfig c)
        {
            return target.DOShakeRotation(c.Duration, c.Strength, c.Vibrato, c.Randomness, c.FadeOut);
        }
    }
}
