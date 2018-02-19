using System;
using UnityEngine;

namespace DOTweenConfigs
{
    [Serializable]
    public class SnapShakeTweenConfig : ShakeTweenConfig
    {
        [SerializeField]
        private bool m_snapping = false;

        public bool Snapping
        {
            get { return m_snapping; }
        }
    }
}
