using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public GameObject mainMenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool IsPaused = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
            mainMenuPanel.SetActive(IsPaused);

            if (IsPaused)
            {      
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }      
        }
    }
}
