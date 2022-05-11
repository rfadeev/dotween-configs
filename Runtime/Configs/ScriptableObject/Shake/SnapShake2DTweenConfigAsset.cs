using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.SnapShake2DTweenConfigAssetFileName,
        menuName = EditorConstants.SnapShake2DTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class SnapShake2DTweenConfigAsset : TweenConfigAsset<SnapShake2DTweenConfig>
    {
    }
}
