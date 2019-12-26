using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum UIState {MAIN_MENU,OPTIONS, CREDITS};
public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public GameObject creditsPanel;
    private UIState currentState;
    void Start()
    {
        currentState = UIState.MAIN_MENU;
        CleanUI();
        mainMenuPanel.SetActive(true);
    }

    void CleanUI() {

        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void PlayGame() {
        SceneManager.LoadScene(1);
    }

    public void Options() {

        optionsPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void Credits() {
        optionsPanel.SetActive(false);
        mainMenuPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }

    public void ReturnOptions() {
        optionsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
    public void ReturnCredits() {
        mainMenuPanel.SetActive(true);
        creditsPanel.SetActive(false);
    }
}
