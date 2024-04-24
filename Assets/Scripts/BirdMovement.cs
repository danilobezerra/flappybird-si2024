using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody2D _rigidbody;
    private Animator _animator;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            _rigidbody.velocity = Vector2.up * speed;
            _animator.SetTrigger("Jump");
        }
    }
}
