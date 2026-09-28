using UnityEngine;

public class MoveCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        public class MoveCube : MonoBehaviour
    {
        
        public float speed = 5f;

        void Update()
        {
            
            if (Input.GetKey(KeyCode.Space))
            {
               
                transform.Translate(Vector3.up * vitesse * Time.deltaTime);
            }
        }
    }
}
}
