using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadScene : MonoBehaviour
{
    public void loadLvl1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void loadLvl2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Loadlvl3()
    {
        SceneManager.LoadScene("Level3");
    }
}
