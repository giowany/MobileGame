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

    private IEnumerator ResetGameCoRotine(bool check0)
    {
        PlayerController.ChangeIsPlaying(check0);
        yield return new WaitForSeconds(1);
        StartGame(!check0);
        
    }

    public void ResetGame()
    {
        StartCoroutine(ResetGameCoRotine(false));
    }

    public void PlayAnimationPlayer(AnimatorManager.AnimatorType type = AnimatorManager.AnimatorType.IDLE)
    {
        PlayerController.PlayAnimation(type);
    }

    public void ShowFinalScreen()
    {
        screen.SetActive(true);
    }
}
