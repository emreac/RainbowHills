using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    //Beep Sound
    //public AudioSource beepSound;
    

    //JUMP ANIMATION
    public Animator animator;
    //SWIPTE GUIDE UI
    public GameObject fingerCanvas;
    //JUMP GUIDE UI
    public GameObject jumpTutorCanvas;
    //OPTION MENU - SLIDER SETTINGS
    public GameObject sliderCanvas;
    //CHARACTER HEAD PARTICUL
    public GameObject headTrail;
    //GUIDE ARROWS
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject arrow4;

    private int currentSceneIndex;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    //OPTION MENU - SLIDER SETTTING MENU
    public void SliderCanvas()
    {
      //beepSound.Play();
        Time.timeScale = 0.0f;
        sliderCanvas.SetActive(true);
    }
    //MENU CLOSE BUTTON
    public void CloseSliderCanvas()
    {
     //beepSound.Play();
        sliderCanvas.SetActive(false);
        Time.timeScale = 1f;
    }


    private void OnTriggerEnter(Collider other)
    {

        //FLY ANIMATION
        if (other.tag == "FlyTrigger")
        {
            animator.SetBool("Fly", true);
        }


        //Next Level Trigger
        if (other.tag == "NextLevelTrigger")
        {
           

        }

        //GUIDE ARROW TRIGGERS

        if (other.tag == "Arrow1Trigger")
        {
            arrow1.SetActive(true);

        }
        if (other.tag == "Arrow2Trigger")
        {
            arrow2.SetActive(true);

        }
        if (other.tag == "Arrow3Trigger")
        {
            arrow3.SetActive(true);

        }
        if (other.tag == "Arrow4Trigger")
        {
            arrow4.SetActive(true);

        }

        //CHARACTER HEAD PARTICUL
        if (other.tag == "HeadTrailTrigger")
        {
            headTrail.SetActive(true);
          
        }

        //SLOW MOTION TRIGGER

        if (other.tag == "SlowMo")
        {
            Time.timeScale = 0.6f;
        }
        //JUMP UI TRIGGER
        if (other.tag == "JumpTutorTrigger")
        {
            jumpTutorCanvas.SetActive(true);
        }

        //SWIPE UI TRIGGER
        if(other.tag == "FingerTutorTrigger")
        {

            fingerCanvas.SetActive(true);
        }

        //OBSTACLE TRIGGER

        if (other.gameObject.tag == "Obstacle")
        {
            Vibration.Vibrate(55);
            headTrail.SetActive(false);
            animator.SetBool("Fall", true);
            Debug.Log("Game Over!");
            Time.timeScale = 0.2f;
            Invoke("RestartGame", 1f);
            Time.timeScale = 1f;

        }
        else
        {
            animator.SetBool("Fall", false);
        }
     
    }

    private void OnTriggerExit(Collider other)
    {
        //FLY ANIMATION
        if (other.tag == "FlyTrigger")
        {
            animator.SetBool("Fly", false);
        }


        //GUIDE ARROW TRIGGERS

        if (other.tag == "Arrow1Trigger")
        {
            arrow1.SetActive(false);

        }
        if (other.tag == "Arrow2Trigger")
        {
            arrow2.SetActive(false);

        }
        if (other.tag == "Arrow3Trigger")
        {
            arrow3.SetActive(false);

        }
        if (other.tag == "Arrow4Trigger")
        {
            arrow4.SetActive(false);

        }

        //SLOW MOTION TRIGGER
        if (other.tag == "SlowMo")
        {
            Time.timeScale = 1;
        }

        //JUMP UI TRIGGER
        if (other.tag == "JumpTutorTrigger")
        {
            jumpTutorCanvas.SetActive(false);
        }
        //SWIPE UI TRIGGER
        if (other.tag == "FingerTutorTrigger")
        {

            fingerCanvas.SetActive(false);
        }


       
    }

    public void MainMenuButton()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        SceneManager.LoadScene(0);
      //beepSound.Play();
     
        Time.timeScale = 1;
    }

    //RESTART GAME
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
