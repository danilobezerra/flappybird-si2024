using UnityEngine;

public class Points : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        var gameController = GameObject.FindGameObjectWithTag("GameController");
        gameManager = gameController.GetComponent<GameManager>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameManager.Score++;
    }
}
