using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] Animator _animator;

    void Update()
    {
        if (Input.anyKey)
        {
            _animator.SetTrigger("Fade");
            Invoke("LoadGame",1);
        }
    }

    private void LoadGame()
    {
        SceneManager.LoadScene("01");
    }
}
