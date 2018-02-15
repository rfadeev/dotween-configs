using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.Position3DTweenConfigAssetFileName,
        menuName = EditorConstants.Position3DTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class Position3DTweenConfigAsset : TweenConfigAsset<Position3DTweenConfig>
    {
    }
}
