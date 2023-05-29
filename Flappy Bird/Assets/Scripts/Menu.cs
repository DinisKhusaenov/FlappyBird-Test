using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnFirstLvlButtonClick()
    {
        SceneManager.LoadScene("FirstLevelScene");
        PlayerPrefs.SetInt("Level", 1);
    }

    public void OnSecondLvlButtonClick()
    {
        SceneManager.LoadScene("SecondLevelScene");
        PlayerPrefs.SetInt("Level", 2);
    }

    public void OnThirdLvlButtonClick()
    {
        SceneManager.LoadScene("ThirdLevelScene");
        PlayerPrefs.SetInt("Level", 3);
    }

    public void OnRestartBtnClick()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        Time.timeScale = 1;
    }

    public void OnMenuBtnClick()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;
    }

    public void OnStartBtnClick()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
