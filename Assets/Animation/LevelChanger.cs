using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class LevelChanger : MonoBehaviour
{
    public Animator animator;

    private int LevelToLoad;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            FadeToLevel(1);
        }

    }

    public void FadeToLevel (int levelIndex)
    {
        LevelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(LevelToLoad);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
