using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    [SerializeField] private Transform mira;
    [SerializeField] private float speedMove;
    [SerializeField] private bool MoveX;
    [SerializeField] private bool MoveY;
    [SerializeField] private Vector3 Offset;

    void Update()
    {
        Vector3 posFinal = this.mira.position + (Vector3)this.Offset;
        posFinal.z = this.transform.position.z;

        if(this.MoveX == false)
        {
            posFinal.x = this.transform.position.x;
        }
        if(this.MoveY == false)
        {
            posFinal.y = this.transform.position.y;
        }

        posFinal = Vector3.Lerp(this.transform.position, posFinal, this.speedMove * Time.deltaTime);

        this.transform.position = posFinal;
    }
}
