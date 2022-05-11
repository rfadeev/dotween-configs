using System;
using UnityEngine;

namespace DOTweenConfigs
{
    [Serializable]
    public class SnapShake2DTweenConfig : Shake2DTweenConfig
    {
        [SerializeField]
        private bool m_snapping = false;

        public bool Snapping
        {
            get { return m_snapping; }
        }
    }
}
