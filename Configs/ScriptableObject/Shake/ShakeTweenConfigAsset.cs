using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.ShakeTweenConfigAssetFileName,
        menuName = EditorConstants.ShakeTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class ShakeTweenConfigAsset : TweenConfigAsset<ShakeTweenConfig>
    {
    }
}
