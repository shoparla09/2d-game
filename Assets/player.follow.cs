    using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UIElements;

public class playerfollow : MonoBehaviour
{
    public Transform followplayer;
    private Vector3 offset;
    private float smoothspeed = 5f;

    void start()
    {
        //object genaamd character vinden om playerfollow te laten werken op charcter.
        GameObject character = GameObject.Find("character");
    }
    void Update()
    {
            //speler volgen doormiddel van  Vector3 desiredPosition = followplayer.position + offset; waardoor Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPosition, smoothspeed * Time.deltaTime); dan transform.position = smoothPos; AlwaysLinkAssemblyAttribute zien
        Vector3 desiredPosition = followplayer.position  +  offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPosition, smoothspeed * Time.deltaTime);
        transform.position = smoothPos;
    }

}
