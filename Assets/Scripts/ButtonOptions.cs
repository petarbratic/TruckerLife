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

    //below here are track selection buttons


    public void RobaZaRestoran()
    {
        SceneManager.LoadScene(2);
    }
}
