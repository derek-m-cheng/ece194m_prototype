using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 20f;

    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * UnityEngine.Time.smoothDeltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
            countdownText.gameObject.SetActive(false);
        }
        if (currentTime <= startingTime/2)
        {
            countdownText.color = Color.red;
        }
    }

}
