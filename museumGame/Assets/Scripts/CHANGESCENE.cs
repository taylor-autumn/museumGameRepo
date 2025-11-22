using UnityEngine;
using UnityEngine.SceneManagement;

public class CHANGESCENE : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goToGame()
    {
        print("GOING TO GAME");
        SceneManager.LoadScene("game");
    }

}
