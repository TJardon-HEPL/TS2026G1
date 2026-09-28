using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 5F;

    private Vector2 _movement;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        _movement.x = input * speed*Time.deltaTime;
        transform.Translate(_movement);
        
    }
}
