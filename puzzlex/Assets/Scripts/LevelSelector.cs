using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void GoToLevel1()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene(4);
    }

    public void GoToLevel4()
    {
        SceneManager.LoadScene(5);
    }

    public void GoToLevel5()
    {
        
    }

    public void GoToLevel6()
    {
        
    }
}
