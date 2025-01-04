using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed;
    private float deadZone = -15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Destroyed Pipe");
            Destroy(gameObject);
        }
    }
}
