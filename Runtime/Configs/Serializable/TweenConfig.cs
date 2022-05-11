using System;
using UnityEngine;

namespace DOTweenConfigs
{
    /// <summary>
    /// Base tween config for any other tween config. Contains
    /// duration parameter which any tweening in DOTween has.
    /// </summary>
    [Serializable]
    public class TweenConfig
    {
        [SerializeField]
        private float m_duration;

        public float Duration
        {
            get { return m_duration; }
        }
    }
}
