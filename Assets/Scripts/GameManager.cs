using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EBAC.Core.Singleton;

public class GameManager : Singleton<GameManager>
{
    public PlayerController PlayerController;
    public LoadScene LoadScene;

    private void DeadPlayer()
    {
        if (PlayerController != null)
        {
            LoadScene.Load(1);
        }
    }
}
