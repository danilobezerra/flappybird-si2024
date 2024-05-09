using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed;

    private float _imageWidth;

    private void Start()
    {
        var image = GetComponentInChildren<SpriteRenderer>();
        _imageWidth = image.sprite.bounds.size.x;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -_imageWidth)
        {
            transform.position = Vector3.zero;
        }
    }
}

