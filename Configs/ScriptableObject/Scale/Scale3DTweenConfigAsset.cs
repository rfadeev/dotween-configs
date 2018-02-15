using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.Scale3DTweenConfigAssetFileName,
        menuName = EditorConstants.Scale3DTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class Scale3DTweenConfigAsset : TweenConfigAsset<Scale3DTweenConfig>
    {
    }
}
