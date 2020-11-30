using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    float enrageTime = 55f;

    [SerializeField] Text countdownText;
    [SerializeField] Text enrageText;
    [SerializeField] Text enrageTimer;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        enrageText.gameObject.SetActive(false);
        enrageTimer.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * UnityEngine.Time.smoothDeltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
        if (currentTime <= startingTime/2)
        {
            countdownText.color = Color.red;
        }
        if (currentTime == 0)
        {

            countdownText.gameObject.SetActive(false);
            enrageText.gameObject.SetActive(true);
            //enrageTimer.gameObject.SetActive(true);
            do
            {
                enrageTime -= 1 * UnityEngine.Time.smoothDeltaTime;
                enrageTimer.text = enrageTime.ToString("0");
            } while (enrageTime >= 0);
        }
    }

}
