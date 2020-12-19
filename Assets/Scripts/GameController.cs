using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject target;
    public Text timerText;
    private float secondsCount;
    public Text winText;
    public Text playAgainText;
    private bool win;

    // Start is called before the first frame update
    void Start()
    {
        winText.gameObject.SetActive(false);
        playAgainText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimerUI();
        if (Input.GetKey(KeyCode.Escape)) {
            doExitGame();
        }
    }

    //call this on update
    public void UpdateTimerUI()
    {
        //set timer UI
        if (win == false) {
            secondsCount += Time.deltaTime;
            timerText.text = "CURRENT RUN'S TIME: " + (int)secondsCount + "s";
        }
        if (target)
        {
      

           if (target.transform.position.x < -1.2 && target.transform.position.y > 56)
            {
                win = true;
                winText.gameObject.SetActive(true);
                playAgainText.gameObject.SetActive(true);
                winText.fontSize = 70;
                winText.text = "YOU WON IN " + (int)secondsCount + "s";
                playAgainText.fontSize = 70;
                if (Input.GetKey(KeyCode.Q))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }

        }

    }

    void doExitGame()
    {
        Application.Quit();
    }
}
