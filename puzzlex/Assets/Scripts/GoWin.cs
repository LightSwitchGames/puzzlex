using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoWin : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    void Update()
    {
        if (PlayerPrefs.GetFloat("BlueOn") == 1 && PlayerPrefs.GetFloat("PinkOn") == 1)
        {
            Debug.Log("You Win");
            StartCoroutine(Won());
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    IEnumerator Won()
    {
        yield return new WaitForSeconds(1);
        winPanel.SetActive(true);
    }
}
