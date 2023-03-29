using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EBAC.Core.Singleton;

public class ColorManager : Singleton<ColorManager>
{
    public List<Material> materials;
    public List<ColorSetup> setups;

    public void ChangeColorArtByType(ArtManager.ArtType artType)
    {
        var setup = setups.Find(i => i.type == artType);
        for(int i = 0; i < materials.Count; i++)
        {
            materials[i].SetColor("_Color", setup.color[i]);
        }
    }
}

[System.Serializable]
public class ColorSetup
{
    public ArtManager.ArtType type;
    public List<Color> color;
}
