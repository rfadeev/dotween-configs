using UnityEngine;

namespace DOTweenConfigs
{
    [CreateAssetMenu(
        fileName = EditorConstants.MoveAxisTweenConfigAssetFileName,
        menuName = EditorConstants.MoveAxisTweenConfigAssetMenuName,
        order = EditorConstants.MoveConfigsOrder)]
    public class MoveAxisTweenConfigAsset : TweenConfigAsset<MoveAxisTweenConfig>
    {
    }
}
