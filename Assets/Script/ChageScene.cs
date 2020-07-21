using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChageScene : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void Change(int index)
    {
        SceneManager.LoadScene(index);
    }
}
