using System;
using UnityEngine;

namespace DOTweenConfigs
{
    /// <summary>
    /// Generic tween config for tweening to some value.
    /// </summary>
    [Serializable]
    public class ToTweenConfig<T> : TweenConfig
    {
        [SerializeField]
        private T m_to;

        public T To
        {
            get { return m_to; }
        }

        public ToTweenConfig()
        {
        }

        public ToTweenConfig(T to)
        {
            m_to = to;
        }
    }
}
