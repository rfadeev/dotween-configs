using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.SnapShake3DTweenConfigAssetFileName,
        menuName = EditorConstants.SnapShake3DTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class SnapShake3DTweenConfigAsset : TweenConfigAsset<SnapShake3DTweenConfig>
    {
    }
}
