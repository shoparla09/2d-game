using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public  CoinManager cm ;

    public Rigidbody2D rb;
    public float _jumpForce = 100f;

    void Start()
    {
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
            Debug.Log("jump was pressed;");
            //rb.linearVelocity = new Vector2(rb.linearVelocity.x, _jumpForce);
            OnplayerinputReceived.Invoke( Vector2.up * _jumpForce );
        }
      
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            cm.coinCount++;
            Destroy(other.gameObject);
        }
    }
}
