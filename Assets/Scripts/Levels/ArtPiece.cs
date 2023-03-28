using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtPiece : MonoBehaviour
{
    private GameObject _currentArt;

    public void ChangeArtPiece(GameObject pieceArt)
    {
        if(_currentArt != null) Destroy(_currentArt);

        _currentArt = Instantiate(pieceArt, transform);
        _currentArt.transform.localPosition = Vector3.zero;
    }
}
