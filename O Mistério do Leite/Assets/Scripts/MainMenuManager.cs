using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenuPanel;
    [SerializeField] private GameObject OptionsMenuPanel;
    //[SerializeField] private AudioSource ButtonSound;

    public void Jogar()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(1);
    }

    public void Opcoes()
    {
        GetComponent<AudioSource>().Play();
        MainMenuPanel.SetActive(false);
        OptionsMenuPanel.SetActive(true);
    }

    public void FecharOpcoes()
    {
        GetComponent<AudioSource>().Play();
        MainMenuPanel.SetActive(true);
        OptionsMenuPanel.SetActive(false);
    }

    public void Sair()
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("Sair do Jogo.");
        Application.Quit();
    }
}
