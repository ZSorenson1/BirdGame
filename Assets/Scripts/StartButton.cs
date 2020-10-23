﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    private void OnMouseDown() 
    {
        GetComponent<SpriteRenderer>().color = Color.gray;
    }
    private void OnMouseUp() 
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        SceneManager.LoadScene("Level1");
    }
}
