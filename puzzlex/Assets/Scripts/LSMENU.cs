using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LSMENU : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
