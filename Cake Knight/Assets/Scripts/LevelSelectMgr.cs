﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMgr : MonoBehaviour
{
    public string levelName = "MainMenu";

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger");

            SceneManager.LoadScene(levelName);
        }
    }
}
