using UnityEngine;
using UnityEngine.UI;

public class DisplayLife : MonoBehaviour
{
    [SerializeField] int lifePoints = 500;

    Text display;

    // Start is called before the first frame update
    void Start()
    {
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
