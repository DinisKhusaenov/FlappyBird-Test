using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _walls;
    [SerializeField] private float _spawnFrequency;
    [SerializeField] private float _height;

    private float _timer;

    private void Start()
    {
        if (PlayerPrefs.GetInt("Level") == 1)
            FirstLevelSpawn();
        else if (PlayerPrefs.GetInt("Level") == 2)
            SecondLevelSpawn();
        else ThirdLevelSpawn();
    }

    private void Update()
    {
        if (_timer >= _spawnFrequency)
        {
            if (PlayerPrefs.GetInt("Level") == 1)
                FirstLevelSpawn();
            else if (PlayerPrefs.GetInt("Level") == 2)
                SecondLevelSpawn();
            else ThirdLevelSpawn();

            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void FirstLevelSpawn()
    {
        GameObject _newWall = Instantiate(_walls[0]);
        _newWall.transform.position = transform.position + new Vector3(0, Random.Range(-_height, _height), 0);
        Destroy(_newWall, 15);
    }

    private void SecondLevelSpawn()
    {
        GameObject _newWall = Instantiate(_walls[Random.Range(0, _walls.Length)]);
        _newWall.transform.position = transform.position + new Vector3(0, Random.Range(-_height, _height), 0);
        Destroy(_newWall, 15);
    }

    private void ThirdLevelSpawn()
    {
        GameObject _newWall = Instantiate(_walls[Random.Range(0, _walls.Length)]);
        _newWall.transform.position = transform.position + new Vector3(0, Random.Range(-_height, _height), 0);
        Destroy(_newWall, 15);
    }
}
