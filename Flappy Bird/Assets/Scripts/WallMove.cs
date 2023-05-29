using UnityEngine;

public class WallMove : MonoBehaviour
{
    [SerializeField] private int _moveSpeed;
    private void Update()
    {
        if (PlayerPrefs.GetInt("Level") == 1)
            transform.Translate(-_moveSpeed * Time.deltaTime, 0, 0);
        else if (PlayerPrefs.GetInt("Level") == 2)
            transform.Translate(-(_moveSpeed + 1) * Time.deltaTime, 0, 0);
        else transform.Translate(-(_moveSpeed + 2) * Time.deltaTime, 0, 0);
    }
}
