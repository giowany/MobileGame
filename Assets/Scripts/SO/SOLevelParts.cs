using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SOLevelParts : ScriptableObject
{
    public ArtManager.ArtType artType;

    [Header("Pieces")]
    public List<LevelPieceBase> levelPieceStart;
    public List<LevelPieceBase> levelPiece;
    public List<LevelPieceBase> levelPieceEnd;
    public int pieceStartNumber = 3;
    public int pieceNumber = 5;
    public int pieceEndNumber = 1;
}
