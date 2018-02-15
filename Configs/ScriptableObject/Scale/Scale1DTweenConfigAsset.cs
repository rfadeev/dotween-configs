using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.Scale1DTweenConfigAssetFileName,
        menuName = EditorConstants.Scale1DTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class Scale1DTweenConfigAsset : TweenConfigAsset<Scale1DTweenConfig>
    {
    }
}
