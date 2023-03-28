using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EBAC.Core.Singleton;

public class LevelManager : Singleton<LevelManager>
{
    public Transform conteiner;
    public List<GameObject> levels;
    public List<SOLevelParts> parts;

    [SerializeField] private int _index;
    private SOLevelParts _currentSetup;
    private List<LevelPieceBase> _levelPieces = new List<LevelPieceBase>();

    private void Awake()
    {
        NextLevel();
        CreatLevelPieces();
        
    }

    public void SpawNextLevel()
    {
        ClearListPieces();
        NextLevel();
        CreatLevelPieces();
    }

    private void NextLevel()
    {
        if (_currentSetup != null)
        {
            _index++;
            if (_index >= parts.Count) ResetIndex();
        }

        _currentSetup = parts[_index];
    }

    private void ResetIndex()
    {
        _index = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            SpawNextLevel();
        }
    }

    #region Level Pieces
    private void CreatPieces(List<LevelPieceBase> list)
    {
        var pieces = list[Random.Range(0, list.Count)];
        var spawnedpiece = Instantiate(pieces, conteiner);

        if(_levelPieces.Count > 0)
        {
            var lastPiece = _levelPieces[_levelPieces.Count - 1];

            spawnedpiece.transform.position = lastPiece.pieceReference.position;
        }

        foreach(var p in spawnedpiece.GetComponentsInChildren<ArtPiece>())
        {
            p.ChangeArtPiece(ArtManager.instance.GetArtByType(_currentSetup.artType).artPart);
        }

        _levelPieces.Add(spawnedpiece);
    }

    private void CreatLevelPieces()
    {
        for(int i = 0; i < _currentSetup.pieceStartNumber; i++)
        {
            CreatPieces(_currentSetup.levelPieceStart);
        }
        
        for(int i = 0; i < _currentSetup.pieceNumber; i++)
        {
            CreatPieces(_currentSetup.levelPiece);
        }
        
        for(int i = 0; i < _currentSetup.pieceEndNumber; i++)
        {
            CreatPieces(_currentSetup.levelPieceEnd);
        }
    }

    private void ClearListPieces()
    {
        for(int i = _levelPieces.Count -1; i >= 0; i--)
        {
            Destroy(_levelPieces[i].gameObject);
        }

        _levelPieces.Clear();
    }

    #endregion
}
