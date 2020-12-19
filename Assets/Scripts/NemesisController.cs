using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NemesisController : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 100f;
    public GameObject target;

    [SerializeField] Text nemesisSpawnText;
    [SerializeField] Text nemesisEnrageText;
    [SerializeField] Text youLose;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        nemesisSpawnText.fontSize = 1;
        nemesisEnrageText.fontSize = 1;
        youLose.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * UnityEngine.Time.smoothDeltaTime;
        nemesisEnrageText.text = currentTime.ToString("0");
        if (currentTime <= 80)
        {
            nemesisSpawnText.fontSize = 30;
            nemesisEnrageText.fontSize = 30;

        }
        if(currentTime <= 0)
        {
            currentTime = 0;
            nemesisEnrageText.fontSize = 1;
            nemesisSpawnText.fontSize = 1;
            Destroy(target);
            youLose.gameObject.SetActive(true);
            youLose.fontSize = 70;
            if (Input.GetKey(KeyCode.Q))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }


        }
        if (currentTime <= startingTime / 2)
        {
           nemesisEnrageText.color = Color.red;
        }
    }

}
