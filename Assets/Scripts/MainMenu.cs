using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void LoadLevelOne()
   {
        SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
   }
   public void LoadLevelTwo()
   {
        SceneManager.LoadScene("Level 2", LoadSceneMode.Single);
   }
   public void LoadLevelThree()
   {
        SceneManager.LoadScene("Level 3", LoadSceneMode.Single);
   }
   public void Quit()
   {
        Application.Quit();
   }
}
