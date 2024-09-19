using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public SpriteRenderer sprite;
    private Rigidbody2D Player;
    private bool pulando;
    [SerializeField] private float velocidade;
    [SerializeField] private float pulo;
    [SerializeField] private Transform chão;
    [SerializeField] private float detector;
    [SerializeField] private LayerMask ground;

    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Movement();
        Jump();

        if(this.pulando)
        {
            if(Input.GetKey(KeyCode.Space))
            {

            }
        }
    }

    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 rapidez = this.Player.velocity;
        rapidez.x = horizontal * this.velocidade;
        this.Player.velocity = rapidez;

        if(rapidez.x > 0)
        {
            this.sprite.flipX = false;
        }
        else if(rapidez.x < 0)
        {
            this.sprite.flipX = true;
        }
    }
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Collider2D collider = Physics2D.OverlapCircle(this.chão.position, this.detector, this.ground);
            if(collider != null)
            {
            Vector2 força = new Vector2(0, this.pulo);
            this.Player.AddForce(força, ForceMode2D.Impulse);
            }
        }
    }

    void OnDrawGizmos() 
    {
        Gizmos.DrawWireSphere(this.chão.position, this.detector);    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Save"))
        {
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Finish"))
        {
            PlayerPrefs.DeleteKey("HasSave");
            SceneManager.LoadScene("Tentativa");
        }
        if(other.CompareTag("sim"))
        {
            SceneManager.LoadScene("Ato2");
        }
        if(other.CompareTag("nao"))
        {
            SceneManager.LoadScene("GameOver");
        }
        if(other.CompareTag("menu"))
        {
            SceneManager.LoadScene("Menu");
        }
        if(other.CompareTag("Ato1"))
        {
            SceneManager.LoadScene("Ato1");
        }
        if(other.CompareTag("vitória"))
        {
            SceneManager.LoadScene("vitória");
        }
        if(other.CompareTag("menu2"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
} 