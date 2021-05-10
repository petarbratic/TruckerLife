using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonOptions : MonoBehaviour
{
    public void FreePlay()
    {
        SceneManager.LoadScene(2);
    }

    public void JobOffers()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //below here are job selection buttons


    public void RobaZaRestoran()
    {
        SceneManager.LoadScene(3);
    }
    public void DostavaHrane()
    {
        SceneManager.LoadScene(2);
    }
    public void Selidba()
    {
        SceneManager.LoadScene(4);
    }
}
