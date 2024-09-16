using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matarinimigo : MonoBehaviour
{
    [SerializeField] private Transform inimigoMatavel;

    void OnTriggerEnter2D(Collider2D morrer)
    {
        if(morrer.CompareTag("Player"))
        {
            Destroy(morrer.gameObject);
        }
    }
}
