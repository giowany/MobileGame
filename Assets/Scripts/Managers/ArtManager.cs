using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EBAC.Core.Singleton;

public class ArtManager : Singleton<ArtManager>
{
    public enum ArtType
    {
        TYPE_01,
        TYPE_02,
        TYPE_03
    }

    public List<ArtSetup> artSetups;

    public ArtSetup GetArtByType(ArtType artType)
    {
        return artSetups.Find(i => i.type == artType);
    }

}

[System.Serializable]
public class ArtSetup
{
    public ArtManager.ArtType type;
    public GameObject artPart;
}
