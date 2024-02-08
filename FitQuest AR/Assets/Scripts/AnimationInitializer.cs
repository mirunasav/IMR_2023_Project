using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationInitializer : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        string animationName = PlayerPrefs.GetString("AnimationName", "");

        Debug.Log(animationName);

        if (!string.IsNullOrEmpty(animationName))
        {
            animator.Play(animationName);
            //animator.Play("bicep_curl");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
