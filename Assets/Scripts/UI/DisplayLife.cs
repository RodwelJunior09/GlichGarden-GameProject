using UnityEngine;
using UnityEngine.UI;

public class DisplayLife : MonoBehaviour
{

    [SerializeField] float lifePoints = 3;
    [SerializeField] int damage = 1;

    float lives;
    Text display;

    // Start is called before the first frame update
    void Start()
    {
        lives = lifePoints - PlayerPrefController.GetDificulty();
        display = GetComponent<Text>();
        UpdateLife();
    }

    public void UpdateLife()
    {
        display.text = lifePoints.ToString();
    }

    public void DecreaseLife(int amount)
    {
        lifePoints -= amount;
        if (lifePoints < 0) lifePoints = 0;
        UpdateLife();
        if (lifePoints <= 0) FindObjectOfType<SceneLoader>().LoadGameOver();
    }
}
