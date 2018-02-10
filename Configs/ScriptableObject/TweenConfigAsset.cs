using UnityEngine;

namespace DOTweenConfigs
{
    public class TweenConfigAsset<T> : ScriptableObject
        where T : TweenConfig
    {
        [SerializeField]
        private T tweenConfig;

        public T TweenConfig
        {
            get { return tweenConfig; }
        }
    }
}
