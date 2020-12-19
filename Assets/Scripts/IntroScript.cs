using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroScript : MonoBehaviour
{
    [SerializeField] Image introScreen;
    public float currentTime = 0f;
    float startingTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * UnityEngine.Time.smoothDeltaTime;
        if (currentTime <= 0)
        {
            currentTime = 0;
            introScreen.gameObject.SetActive(false);
        }
    }
}
