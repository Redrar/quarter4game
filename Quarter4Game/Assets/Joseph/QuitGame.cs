﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void OnMouseDown()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}

