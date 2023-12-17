using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pink")
        {
            PlayerPrefs.SetFloat("PinkOn",1);
            Debug.Log(PlayerPrefs.GetFloat("PinkOn"));
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Pink")
        {
            PlayerPrefs.SetFloat("PinkOn",0);
            Debug.Log(PlayerPrefs.GetFloat("PinkOn"));
        }
    }
}