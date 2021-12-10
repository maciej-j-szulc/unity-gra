using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameManager>().CompleteLevel();
        Destroy(gameObject);
    }
}
