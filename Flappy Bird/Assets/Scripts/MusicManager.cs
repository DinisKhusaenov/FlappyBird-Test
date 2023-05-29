using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private Toggle _musicToggle;
    [SerializeField] private Slider _musicSlider;
    [SerializeField] private AudioSource _audioSource;

    private float _volume;

    private void Start()
    {
        Load();
        ValueMusic();
    }

    public void SliderMusic()
    {
        _volume = _musicSlider.value;
        Save();
        ValueMusic();
    }

    public void ToggleMusic()
    {
        if (_musicToggle.isOn) _volume = 1;
        else _volume = 0;

        Save();
        ValueMusic();
    }

    private void ValueMusic()
    {
        _audioSource.volume = _volume;
        _musicSlider.value = _volume;

        if (_volume == 0) _musicToggle.isOn = false;
        else _musicToggle.isOn = true;
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("Volume", _volume);
    }

    private void Load()
    {
        _volume = PlayerPrefs.GetFloat("Volume");
    }
}
