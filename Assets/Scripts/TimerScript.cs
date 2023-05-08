using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public TMP_Text timerText;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;
        string minutes = Mathf.FloorToInt(t / 60).ToString("00");
        string seconds = Mathf.FloorToInt(t % 60).ToString("00");
        timerText.text = minutes + ":" + seconds;
    }
}
