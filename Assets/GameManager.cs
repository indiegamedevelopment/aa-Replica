using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    private bool gameHasEnded = false;
    
    public Rotator rotator;
    public Spawnner spawnner;
    public Animator animator;
    
    public void EndGame ()
    {
        if (gameHasEnded)
            return;

            rotator.enabled = false;
            spawnner.enabled = false;

            animator.SetTrigger("EndGame");

        gameHasEnded = true;    
        Debug.Log("GAME OVER");
    }

    public void RestartLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
