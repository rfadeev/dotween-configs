#if DOTWEEN_UI_MODULE_ENABLED

using UnityEngine.UI;
using DG.Tweening;

namespace DOTweenConfigs
{
    public static partial class DOTweenExtensions
    {
        public static Tweener DOColor(this Graphic target, ColorTweenConfig c)
        {
            return target.DOColor(c.To, c.Duration);
        }
    }
}

#endif
