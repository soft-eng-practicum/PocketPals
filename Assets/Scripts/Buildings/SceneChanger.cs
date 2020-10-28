﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string newScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //SceneManager.LoadScene(newScene, LoadSceneMode.Single);
        SceneManager.LoadSceneAsync(newScene, LoadSceneMode.Additive);
    }

}
