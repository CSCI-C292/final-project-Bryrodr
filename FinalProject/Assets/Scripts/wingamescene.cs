using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wingamescene : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true; 
    }

 public void playagain(){
     Cursor.lockState = CursorLockMode.None;
     SceneManager.LoadScene(0);
 }
}
