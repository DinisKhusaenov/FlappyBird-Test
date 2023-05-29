using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float _forceJump;
    [SerializeField] private GameObject _losePanel;

    private Rigidbody2D _rigidbody2D;

    private Animator _animator;


    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _losePanel.SetActive(false);

        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _rigidbody2D.velocity = Vector2.up * _forceJump;
            _animator.Rebind();
            _animator.Play("Fly");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        Time.timeScale = 0;
        _losePanel.SetActive(true);
    }
}
