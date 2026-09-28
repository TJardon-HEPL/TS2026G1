using UnityEngine;

public class Move : MonoBehaviour
{
    
    public Vector3 speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime;
    }
}
