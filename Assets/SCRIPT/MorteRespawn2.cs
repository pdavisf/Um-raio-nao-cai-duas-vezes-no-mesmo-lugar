using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MorteRespawn2 : MonoBehaviour
{
    [SerializeField] private Transform Player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Ato2");
            print("Começa denovo kkk!");
        }
    }
}
