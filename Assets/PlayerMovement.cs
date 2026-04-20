using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    private float speed = 5f;
    private  CoinManager cm ;

    private Rigidbody2D rb;
    private float _jumpForce = 100f;

    void Start()
    {
        //inroepen van player.follow class die ervoor zorgt dat speler gevolgd wordt.
        playerfollow followplayer = FindAnyObjectByType<playerfollow>();

        rb = transform.GetComponent<Rigidbody2D>();

        if(followplayer != null)
        {
            followplayer.followplayer = this.transform;
        }
    }
   

    public UnityEvent<Vector2> OnplayerinputReceived = new UnityEvent<Vector2>();
   
    void Update()
    {
        //movemnt voor character (W,A,D || space)
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow))) 
        {
            OnplayerinputReceived.Invoke(Vector2.left * speed);
        }

        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow))) 
        {
            OnplayerinputReceived.Invoke(Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.Space)))
        {
            OnplayerinputReceived.Invoke(Vector2.up * _jumpForce);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
   

    //laat coins verwijderen zodra die in aanraking komt met speler
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            cm.coinCount++;
            Destroy(other.gameObject);

            
        }

        // condition to end the game! can be worked upon
        if (cm.coinCount == 3)
        {
            Debug.Log("Game over! You won!");
        }
    }
}
