[![license](https://img.shields.io/github/license/rfadeev/dotween-configs.svg)](https://github.com/rfadeev/unity-forge-anim-callbacks/blob/master/LICENSE.md)

# DOTween Configs
Configs to setup DOTween's tween parameters via Unity editor.

## Motivation
While [DOTween](http://dotween.demigiant.com) provides shortcuts to start tween with given parameters,
these parameters are usually either hardcoded, extracted to constants or serialized by Unity.
Only latter approach allows tuning parameters via Unity editor without code changes. Since DOTween API
expects each parameter to be passed separately, it's not convinent to setup various tweens this way.
The goal of this project is to ease such configuration.

## How to use
DOTween is required for tween configs. You can download it [here](http://dotween.demigiant.com/download.php).

Add this repository as submodule under `Assets` folder or download it and put to `Assets` folder of your Unity project.
Import `DOTweenConfigs` namespace to use tween configs.

There are two ways to use tween configs: either use [serializable version](https://github.com/rfadeev/dotween-configs/tree/master/Configs/Serializable) or [scriptable object](https://github.com/rfadeev/dotween-configs/tree/master/Configs/ScriptableObject) one.
Scriptable object version allows sharing same tween config between several objects.

### Serializable version
Add tween config serializable field to your object and setup tween parameters.
Use coressponding extension method to start tween with this tween config.

Example of serializable [position 3D tween config](https://github.com/rfadeev/dotween-configs/blob/master/Configs/Serializable/Position/Position3DTweenConfig.cs)
used in `DOMove` extension method:
```chsarp
using UnityEngine;
using DOTweenConfigs;

public class DOMoveSerializableExample : MonoBehaviour
{
    [SerializeField]
    private Position3DTweenConfig tweenConfig;

    private void Start()
    {
        transform.DOMove(tweenConfig);
    }
}
```

### Scriptable object version
First create scriptable object asset for tween config. Available options can be found in create asset menu.
Navigate there either via top Unity panel "Assets/Create/DOTweenConfigs" or via "Create" button in project
window: "Create/DOTweenConfigs". After clicking desired config, new asset file with tween config is created.
Setup tween parameters for tween config asset via inspector.
Add tween config asset serializable field to your object and link desired tween config asset. 
Use coressponding extension method to start tween with this tween config asset.

Example of [position 3D tween config scriptable object](https://github.com/rfadeev/dotween-configs/blob/master/Configs/ScriptableObject/Position/Position3DTweenConfigAsset.cs)
used in `DOMove` extension method:
```chsarp
using UnityEngine;
using DOTweenConfigs;

public class DOMoveScriptableObjectExample : MonoBehaviour
{
    [SerializeField]
    private Position3DTweenConfig tweenConfigAsset;

    private void Start()
    {
        transform.DOMove(tweenConfigAsset.TweenConfig);
    }
}
```

## Installation
Project supports Unity Package Manager. To install project as Git package, update package manifest dependencies to have `com.rfadeev.dotweenconfigs` package:
```json
{
  "dependencies": {
    "com.rfadeev.dotweenconfigs": "https://github.com/rfadeev/dotween-configs"
  }
}
```

To use DOTween configs for Physics, Physics2D, Sprites and UI DOTween modules, additionnal setup is required.
1. Create assembly definition file for DOTween modules. For that click "Create ASMDEF..." button in DOTween Utility Panel.
2. Add following defines to your [scripting define symbols](https://docs.unity3d.com/Manual/CustomScriptingSymbols.html)
    * `DOTWEEN_PHYSICS_MODULE_ENABLED` for Physics module
    * `DOTWEEN_PHYSICS2D_MODULE_ENABLED` for Physics2D module
    * `DOTWEEN_SPRITE_MODULE_ENABLED` for Sprite module. It is called Sprites module in the DOTween Utility Panel, but Sprite in the DOTween code.
    * `DOTWEEN_UI_MODULE_ENABLED` for UI module
