    using UnityEngine;

public class playerfollow : MonoBehaviour
{
    public Transform followplayer;
    public Vector3 offset;
    public float smoothspeed = 5f;

    void start()
    {
        GameObject character = GameObject.Find("character");
    }
    void Update()
    {
        Vector3 desiredPosition = followplayer.position  +  offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPosition, smoothspeed * Time.deltaTime);
        transform.position = smoothPos;
    }

}
