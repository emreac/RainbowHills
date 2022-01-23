using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{

   // public AudioSource beepSound;
    //Congrats Canvas
    public GameObject congratCanvas;
    public Follower follower;
    int levelUnlocked;
    Button[] levelButtons;
    private int sceneToContinue;

    // Start is called before the first frame update
    void Start()
    {
        levelUnlocked = PlayerPrefs.GetInt("levelUnlocked", 1);

        for(int i = 0; i < levelButtons.Length;i++)
        {
            levelButtons[i].interactable = false;
        }
        for(int i = 0; i < levelUnlocked;i++)
        {
            levelButtons[i].interactable = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
       // beepSound.Play();
        SceneManager.LoadScene("Level0");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Vibration.Vibrate(55);
            congratCanvas.SetActive(true);
            //float newSpeed = follower.speed;
            follower.speed = 0f;
        }
    }

    public void ContinueButton()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        if(sceneToContinue != 0)
        {
            SceneManager.LoadScene(sceneToContinue);
        }
        else
        {
            return;
        }
    }

    public void NextLevelButton()
    {
        
       
        // beepSound.Play();
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
