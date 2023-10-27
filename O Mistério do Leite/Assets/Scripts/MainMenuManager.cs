using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene(1);
    }

    public void Opcoes()
    {

    }

    public void FecharOpcoes()
    {

    }

    public void Sair()
    {
        Debug.Log("Sair do Jogo.");
        Application.Quit();
    }
}
