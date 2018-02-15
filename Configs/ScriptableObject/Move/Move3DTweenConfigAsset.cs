using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.Move3DTweenConfigAssetFileName,
        menuName = EditorConstants.Move3DTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class Move3DTweenConfigAsset : TweenConfigAsset<Move3DTweenConfig>
    {
    }
}
