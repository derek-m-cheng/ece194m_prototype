using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NemesisController : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 30f;

    [SerializeField] Text nemesisSpawnText;
    [SerializeField] Text nemesisEnrageText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        nemesisSpawnText.fontSize = 1;
        nemesisEnrageText.fontSize = 1;

    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * UnityEngine.Time.smoothDeltaTime;
        nemesisEnrageText.text = currentTime.ToString("0");
        if (currentTime <= 10)
        {
            nemesisSpawnText.fontSize = 30;
            nemesisEnrageText.fontSize = 30;

        }
        if(currentTime <= 0)
        {
            currentTime = 0;
        }
        if (currentTime <= startingTime / 2)
        {
           nemesisEnrageText.color = Color.red;
        }
    }

}
