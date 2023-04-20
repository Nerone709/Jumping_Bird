using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartupMenu : MonoBehaviour
{
    public GameObject startupMenu;

    public void startGame() {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void openSettings() {
        SceneManager.LoadScene("Settings", LoadSceneMode.Additive);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
