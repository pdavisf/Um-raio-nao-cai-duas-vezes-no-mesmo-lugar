using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    void Update()
    {
        RestarGame();
    }

    void RestarGame()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene("Ato1");
        }
    }
}
