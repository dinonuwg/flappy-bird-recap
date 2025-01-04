using UnityEngine;

public class BackgroundScrollScript : MonoBehaviour
{
    public float scrollSpeed;
    private float backgroundWidth;

    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        backgroundWidth = spriteRenderer.bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, backgroundWidth);
        transform.position = startPosition + Vector3.left * newPosition;
    }
}
