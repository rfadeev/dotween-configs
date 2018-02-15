using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.Move2DTweenConfigAssetFileName,
        menuName = EditorConstants.Move2DTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class Move2DTweenConfigAsset : TweenConfigAsset<Move2DTweenConfig>
    {
    }
}
