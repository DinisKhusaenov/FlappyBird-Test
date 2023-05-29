using UnityEngine;

public class ScorePointer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Bird>(out Bird _bird))
            Score._score++;
    }
}
