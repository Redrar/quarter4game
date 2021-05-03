using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startscript : MonoBehaviour
{
    public int LoadSceneNumber;
    void OnMouseDown()
    {
        SceneManager.LoadScene(LoadSceneNumber);
    }
}
