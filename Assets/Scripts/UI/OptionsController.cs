using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider dificultySlider;

    [SerializeField] float defaultVolume = 0.7f;
    [SerializeField] float defaultDificulty = 1f;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefController.GetMasterVolume();
        dificultySlider.value = PlayerPrefController.GetDificulty();
    }

    // Update is called once per frame
    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicController>();
        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No music player found.");
        }
    }

    public void SaveOptionsAndExit()
    {
        PlayerPrefController.SetMasterVolume(volumeSlider.value);
        FindObjectOfType<SceneLoader>().StartScreen();
        PlayerPrefs.Save();
    }

    public void SetDefault()
    {
        volumeSlider.value = defaultVolume;
        dificultySlider.value = defaultDificulty;
    }
}
