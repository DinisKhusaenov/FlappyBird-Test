using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    public static int _score = 0;

    private void Start()
    {
        _score = 0;
    }

    private void Update()
    {
        _scoreText.text = _score.ToString();
    }
}
