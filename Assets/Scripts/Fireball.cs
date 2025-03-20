using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Rigidbody fireballRb;
    public float speed = 5f;
    public float destroyTimer = 1.5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fireballRb.linearVelocity = transform.forward * speed;
        Destroy(gameObject, destroyTimer);
    }

}
