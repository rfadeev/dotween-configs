using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.ColorTweenConfigAssetFileName,
        menuName = EditorConstants.ColorTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class ColorTweenConfigAsset : TweenConfigAsset<ColorTweenConfig>
    {
    }
}
