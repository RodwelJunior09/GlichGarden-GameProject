using UnityEngine;

public class PlayerPrefController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "dificulty";

    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    const float MAX_DIFICULTY = 2f;
    const float MIN_DIFICULTY = 0f;
    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Volume is out of bounds.");
        }
    }

    public static float GetMasterVolume() => PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);

    public static void SetDificulty(float dificulty)
    {
        if (dificulty >= MIN_DIFICULTY && dificulty <= MAX_DIFICULTY)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, dificulty);
        }
        else
        {
            Debug.LogError("");
        }
    }

    public static float GetDificulty() => PlayerPrefs.GetFloat(DIFFICULTY_KEY);
}
