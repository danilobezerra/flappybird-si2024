using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
        transform.position += speed 
            * Time.deltaTime * Vector3.left;
    }
}
