﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Animator _animator;

    //void Update()
    //{
    //    if (Input.anyKey)
    //    {
            
    //    }
    //}

    public void StartGame()
    {
        _animator.SetTrigger("Fade");
        Invoke("LoadGame", 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    private void LoadGame()
    {
        SceneManager.LoadScene(1);
    }


}
