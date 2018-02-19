using System;
using UnityEngine;

namespace DOTweenConfigs
{
    [Serializable]
    public class BaseShakeTweenConfig<T> : TweenConfig
    {
        [SerializeField]
        private T m_strength;
        [SerializeField]
        private int m_vibrato = 10;
        [SerializeField]
        private float m_randomness = 90;
        [SerializeField]
        private bool m_fadeOut = true;

        public T Strength
        {
            get { return m_strength; }
        }

        public int Vibrato
        {
            get { return m_vibrato; }
        }

        public float Randomness
        {
            get { return m_randomness; }
        }

        public bool FadeOut
        {
            get { return m_fadeOut; }
        }
    }
}
