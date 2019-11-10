using Assets.scripts.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    // MainMenu

    public GameObject MainMenuCanvas;
    public GameObject LostMenuCanvas;
    public GameObject WinMenuCanvas;

    // Gamepay Items
    public GameObject bNotes;
    public GameObject bCoins;

    // Gameplay coin/notes storage...

    public GameObject b500cash;
    public GameObject b200cash;
    public GameObject b100cash;
    public GameObject b50cash;
    public GameObject b20cash;
    public GameObject b10cash;
    public GameObject b5cash;
    public GameObject b2cash;
    public GameObject b1cash;
    public GameObject c50cash;
    public GameObject c20cash;
    public GameObject c10cash;
    public GameObject c5cash;
    public GameObject c2cash;
    public GameObject c1cash;

    public GameObject right;
    public GameObject wrong;

    public Text TargetValueText;
    public Text CurrentValueText;
    public Text LoseMessage;
    public Text LevelText;
    public Text Timer;
    public GameObject TimerFG;
    public int currentLevel = 0;
    float maxTimeLeft = 30f;
    public float timeLeft = 0f;
    public bool isRunning = false;
    public float TargetValue = 0f;
    public int loop1 = 0;

    public Change change = new Change();

    public List<float> levels = new List<float>();

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        MainMenuCanvas.SetActive(true);
        LostMenuCanvas.SetActive(false);
        Timer.text = maxTimeLeft.ToString();
        ResetLevels();
        ResetCashCounters();
    }

    public void ResetCashCounters()
    {
        foreach (Transform child in b500cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in b200cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in b100cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in b50cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in b20cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in b10cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in b5cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in b2cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in b1cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in c50cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in c20cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in c10cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in c5cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in c2cash.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in c1cash.transform)
        {
            Destroy(child.gameObject);
        }
    }



    public void CreateCashCounter()
    {
        for (var i = 0; i < change.b500; i++)
        {
            GameObject b = Instantiate(bNotes, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(b500cash.gameObject.transform);
        }
        for (var i = 0; i < change.b200; i++)
        {
            GameObject b = Instantiate(bNotes, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(b200cash.gameObject.transform);
        }
        for (var i = 0; i < change.b100; i++)
        {
            GameObject b = Instantiate(bNotes, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(b100cash.gameObject.transform);
        }
        for (var i = 0; i < change.b50; i++)
        {
            GameObject b = Instantiate(bNotes, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(b50cash.gameObject.transform);
        }
        for (var i = 0; i < change.b20; i++)
        {
            GameObject b = Instantiate(bNotes, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(b20cash.gameObject.transform);
        }
        for (var i = 0; i < change.b10; i++)
        {
            GameObject b = Instantiate(bNotes, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(b10cash.gameObject.transform);
        }
        for (var i = 0; i < change.b5; i++)
        {
            GameObject b = Instantiate(bNotes, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(b5cash.gameObject.transform);
        }
        for (var i = 0; i < change.b2; i++)
        {
            GameObject b = Instantiate(bNotes, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(b2cash.gameObject.transform);
        }
        for (var i = 0; i < change.b1; i++)
        {
            GameObject b = Instantiate(bNotes, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(b1cash.gameObject.transform);
        }
        for (var i = 0; i < change.c50; i++)
        {
            GameObject b = Instantiate(bCoins, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(c50cash.gameObject.transform);
        }
        for (var i = 0; i < change.c20; i++)
        {
            GameObject b = Instantiate(bCoins, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(c20cash.gameObject.transform);
        }
        for (var i = 0; i < change.c10; i++)
        {
            GameObject b = Instantiate(bCoins, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(c10cash.gameObject.transform);
        }
        for (var i = 0; i < change.c5; i++)
        {
            GameObject b = Instantiate(bCoins, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(c5cash.gameObject.transform);
        }
        for (var i = 0; i < change.c2; i++)
        {
            GameObject b = Instantiate(bCoins, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(c2cash.gameObject.transform);
        }
        for (var i = 0; i < change.c1; i++)
        {
            GameObject b = Instantiate(bCoins, Vector3.zero, Quaternion.identity);
            b.transform.SetParent(c1cash.gameObject.transform);
        }
    }

    public void ResetLevels()
    {
        levels.Clear();
        for (var i = 0; i < 100; i++)
        {
            levels.Add((float)Math.Round(UnityEngine.Random.Range(10f, 5000.0f) * 2, MidpointRounding.AwayFromZero) / 2);
        }
    }

    public void StartGame()
    {
        loop1 = 0;
        MainMenuCanvas.SetActive(false);
        LostMenuCanvas.SetActive(false);
        timeLeft = maxTimeLeft;
        TargetValue = levels[currentLevel];
        LevelText.text = "Level " + (currentLevel + 1).ToString() + " / 100";
        change = new Change();
        isRunning = true;
        ResetCashCounters();
    }

    public void GameWon()
    {
        if(currentLevel == 99)
        {
            MainMenuCanvas.SetActive(false);
            MainMenuCanvas.SetActive(false);
            WinMenuCanvas.SetActive(true);
            return;
        }

        //Display Next Game
        currentLevel = currentLevel + 1;
        StartGame();
    }

    public void GameLost()
    {
        //Dispay Game Lost Message
        currentLevel = 0;
        LoseMessage.text = "You Lost!\n\nYou've Reached Level "+currentLevel+"\n\nClick Here To Start A New Game";
        LostMenuCanvas.SetActive(true);
        ResetLevels();
    }

    void Update()
    {
        if(isRunning)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                isRunning = false;
                timeLeft = 0;
                if (TargetValue == change.GetTotal())
                {
                    GameWon();
                    return;
                }
                else
                {
                    GameLost();
                    return;
                }
            } else
            {
                if(TargetValue == change.GetTotal())
                {
                    loop1++;
                    if (loop1 == 30)
                    {
                        GameWon();
                        return;
                    }
                }
            }


            // Update UI Timer and Slider
            Timer.text = timeLeft.ToString();
            var TimerFGRectTransform = TimerFG.transform as RectTransform;
            TimerFGRectTransform.sizeDelta = new Vector2(1920 * (timeLeft/maxTimeLeft), TimerFGRectTransform.sizeDelta.y);

            // Update UI Current Tota Value
            TargetValueText.text = TargetValue.ToString("C");
            CurrentValueText.text = change.GetTotal().ToString("C");

            if (TargetValue == change.GetTotal())
            {
                right.SetActive(true);
                wrong.SetActive(false);
            }
            else
            {
                wrong.SetActive(true);
                right.SetActive(false);
            }

            // Update UI Coins and Bill Counter
            ResetCashCounters();
            CreateCashCounter();
        }
    }
        
    // UI Inputs for coins
    #region 500
    public void b500a() {change.b500++; }
    public void b500m() { if (change.b500 > 0) change.b500--; }
    #endregion

    #region 200
    public void b200a() { change.b200++; }
    public void b200m() { if (change.b200 > 0) change.b200--; }
    #endregion

    #region 100
    public void b100a() { change.b100++; }
    public void b100m() { if (change.b100 > 0) change.b100--; }
    #endregion

    #region 50
    public void b50a() { change.b50++; }
    public void b50m() { if (change.b50 > 0) change.b50--; }
    #endregion

    #region 20
    public void b20a() { change.b20++; }
    public void b20m() { if (change.b20 > 0) change.b20--; }
    #endregion

    #region 10
    public void b10a() { change.b10++; }
    public void b10m() { if (change.b10 > 0) change.b10--; }
    #endregion

    #region 5
    public void b5a() { change.b5++; }
    public void b5m() { if (change.b5 > 0) change.b5--; }
    #endregion

    #region 2
    public void b2a() { change.b2++; }
    public void b2m() { if (change.b2 > 0) change.b2--; }
    #endregion

    #region 1
    public void b1a() { change.b1++; }
    public void b1m() { if (change.b1 > 0) change.b1--; }
    #endregion

    #region c50
    public void c50a() { change.c50++; }
    public void c50m() { if (change.c50 > 0) change.c50--; }
    #endregion

    #region c20
    public void c20a() { change.c20++; }
    public void c20m() { if (change.c20 > 0) change.c20--; }
    #endregion

    #region c10
    public void c10a() { change.c10++; }
    public void c10m() { if (change.c10 > 0) change.c10--; }
    #endregion

    #region c5
    public void c5a() { change.c5++; }
    public void c5m() { if (change.c5 > 0) change.c5--; }
    #endregion
    
    #region c2
    public void c2a() { change.c2++; }
    public void c2m() { if (change.c2 > 0) change.c2--; }
    #endregion

    #region c1
    public void c1a() { change.c1++; }
    public void c1m() { if(change.c1 > 0)change.c1--; }
    #endregion
}

