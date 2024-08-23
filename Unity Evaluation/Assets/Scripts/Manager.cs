using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private int pointsActual;
    [SerializeField] private TMP_Text pointsUI;
    [SerializeField] private int pointsGoal;
    [SerializeField] private int timer;
    [SerializeField] private TMP_Text timerUI;
    private bool isOver;
    [SerializeField] private GameObject winUI;
    [SerializeField] private GameObject lostUI;

    [SerializeField] private AudioSource winSound;
    [SerializeField] private AudioSource lostSound;

    public void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(TimerCounter());
        timerUI.text = "Temps restant : " + timer;
    }

    public IEnumerator TimerCounter()
    {
        while (timer > 0 && !isOver)
        {
            yield return new WaitForSeconds(1);
            timer--;
            timerUI.text = "Temps restant : " + timer;
        }

        if(timer == 0)
        {
            End(false);
        }
    }

    public void AddPoint()
    {
        pointsActual++;
        pointsUI.text = "Fromages : " + pointsActual;
        if (pointsActual == pointsGoal) End(true);
    }

    public void End(bool isWin)
    {
        isOver = true;

        Time.timeScale = 0;

        if (isWin)
        {
            winSound.Play();
            winUI.SetActive(true);
        }
        else
        {
            lostSound.Play();
            lostUI.SetActive(true);
        }

    }
}
