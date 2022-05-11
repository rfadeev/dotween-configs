using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.Position2DTweenConfigAssetFileName,
        menuName = EditorConstants.Position2DTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class Position2DTweenConfigAsset : TweenConfigAsset<Position2DTweenConfig>
    {
    }
}
