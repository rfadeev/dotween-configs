using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.Move1DTweenConfigAssetFileName,
        menuName = EditorConstants.Move1DTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class Move1DTweenConfigAsset : TweenConfigAsset<Move1DTweenConfig>
    {
    }
}
