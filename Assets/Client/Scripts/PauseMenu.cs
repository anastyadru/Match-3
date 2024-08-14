// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved

using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseGameMenu;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        SetPauseState(false);
    }

    public void Pause()
    {
        SetPauseState(true);
    }

    private void SetPauseState(bool pause)
    {
        isPaused = pause;
        pauseGameMenu.SetActive(pause);
        Time.timeScale = pause ? 0f : 1f;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}