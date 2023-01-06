using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EBAC.Core.Singleton;

public class GameManager : Singleton<GameManager>
{
    public PlayerController PlayerController;
    public GameObject screen;

    public void StartGame(bool check)
    {
        PlayerController.ChangeIsPlaying(check);
    }

    public void ShowFinalScreen()
    {
        screen.SetActive(true);
    }
}