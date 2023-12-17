using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Blue")
        {
            PlayerPrefs.SetFloat("BlueOn",1);
            Debug.Log(PlayerPrefs.GetFloat("BlueOn"));
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Blue")
        {
            PlayerPrefs.SetFloat("BlueOn",0);
            Debug.Log(PlayerPrefs.GetFloat("BlueOn"));
        }
    }
}
