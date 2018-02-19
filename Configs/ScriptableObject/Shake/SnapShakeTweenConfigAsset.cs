using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.SnapShakeTweenConfigAssetFileName,
        menuName = EditorConstants.SnapShakeTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class SnapShakeTweenConfigAsset : TweenConfigAsset<SnapShakeTweenConfig>
    {
    }
}
