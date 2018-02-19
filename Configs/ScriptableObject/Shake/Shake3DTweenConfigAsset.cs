using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.Shake3DTweenConfigAssetFileName,
        menuName = EditorConstants.Shake3DTweenConfigAssetMenuName,
        order = EditorConstants.CreateAssetMenuOrder)]
    public class Shake3DTweenConfigAsset : TweenConfigAsset<Shake3DTweenConfig>
    {
    }
}
