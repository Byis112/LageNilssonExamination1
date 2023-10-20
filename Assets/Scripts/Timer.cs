using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] float targetTime = 30f;
    [SerializeField] GameObject EndScreen;
    [SerializeField] TMP_Text timer;
    private void Awake()
    {
        Time.timeScale = 1;
    }

    private void FixedUpdate()
    {
        targetTime -= Time.deltaTime;
        timer.text = "Time:" + targetTime.ToString() +"s";
        if (targetTime <= 0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        EndScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
