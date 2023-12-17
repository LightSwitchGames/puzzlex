using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinResolver : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetFloat("BlueOn", 0);
        PlayerPrefs.SetFloat("PinkOn", 0);
        Debug.Log("Done!");
    }
}
