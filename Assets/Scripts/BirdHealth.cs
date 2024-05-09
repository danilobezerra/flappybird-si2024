using UnityEngine;

public class BirdHealth : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        var gameController = GameObject.FindGameObjectWithTag("GameController");
        gameManager = gameController.GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
