using System;
using UnityEngine;

namespace DOTweenConfigs
{
    [Serializable]
    public class ColorTweenConfig : ToTweenConfig<Color>
    {
        public ColorTweenConfig() : base(Color.white)
        {
        }
    }
 }
