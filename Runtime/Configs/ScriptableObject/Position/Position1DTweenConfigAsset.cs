using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.Position1DTweenConfigAssetFileName,
        menuName = EditorConstants.Position1DTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class Position1DTweenConfigAsset : TweenConfigAsset<Position1DTweenConfig>
    {
    }
}
