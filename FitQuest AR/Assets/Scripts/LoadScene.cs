using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
   public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);

        PlayerPrefs.SetString("AnimationName", "knee_punch");
    }

    public void AnimationSceneLoader (string animationName)
    {
        SceneManager.LoadScene(1);

        PlayerPrefs.SetString("AnimationName", animationName);
    }
}
