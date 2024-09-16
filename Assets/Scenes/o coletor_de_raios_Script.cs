using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
    public int MaxHealth;
    public float speed;
    public ParticleSystem system;
    private int currentHealth;

    // Start is called before the first frame update
    public void Start()
    {
        currentHealth = MaxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
        Shoot();
    }

    private void Move()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * direction * speed * Time.deltaTime;
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Ativa o sistema de partículas e emite um burst (estouro) de partículas
            if (system != null)
            {
                system.Emit(30);  // Emite 30 partículas para simular um raio
            }
        }
    }
}
