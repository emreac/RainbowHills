using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateWithJoustick : MonoBehaviour
{
    //Rotation Badge
  


    
         

    //JUMP ANIMATION 
    public Animator jumpAnimator1;
    public Animator jumpAnimator2;
    public Animator jumpAnimator3;
    public Animator jumpAnimator4;
    public Animator jumpAnimator5;
    public Animator jumpAnimator6;
    public Animator jumpAnimator7;
    public Animator jumpAnimator8;
    public Animator jumpAnimator9;
    public Animator jumpAnimator10;
    public Animator jumpAnimator11;
    public Animator jumpAnimator12;
    public Animator jumpAnimator13;
    public Animator jumpAnimator14;
    public Animator jumpAnimator15;
    public Animator jumpAnimator16;

    //SLIDER DEFUALT VALUE
    public float sliderValue = 5f;
    //CALL JOYSTICK
    public DynamicJoystick dynamicJoystick;
    //HORIZONTAL ROTATE VALUE
    public float rotateHorizontal;

    //SWIPTE SETTING SLIDER
    public Slider slider;

  

    private void Start()
    {
        //CALL SAVED DATA
        slider.value = PlayerPrefs.GetFloat("save", sliderValue);
     
    }

    private void Update()
    {
        //Rotate Test
       

        //JUMP TEST FOR KEYBOARD
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpAction();
        }

    

    }


    //SAVE SLIDER VALUE
    public void SliderSetting(float newSliderValue)
    {
        sliderValue = newSliderValue;
        PlayerPrefs.SetFloat("save", sliderValue);
    }

    private void FixedUpdate()
    {
        rotateHorizontal = dynamicJoystick.Horizontal * -sliderValue;
        transform.Rotate(0, 0, rotateHorizontal);

       

    }
    
 


    
    public void JumpEnd()
    {
        jumpAnimator1.SetBool("Jump", false);
        jumpAnimator2.SetBool("Jump", false);
        jumpAnimator3.SetBool("Jump", false);
        jumpAnimator4.SetBool("Jump", false);
        jumpAnimator5.SetBool("Jump", false);
        jumpAnimator6.SetBool("Jump", false);
        jumpAnimator7.SetBool("Jump", false);
        jumpAnimator8.SetBool("Jump", false);
        jumpAnimator9.SetBool("Jump", false);
        jumpAnimator10.SetBool("Jump", false);
        jumpAnimator11.SetBool("Jump", false);
        jumpAnimator12.SetBool("Jump", false);
        jumpAnimator13.SetBool("Jump", false);
        jumpAnimator14.SetBool("Jump", false);
        jumpAnimator15.SetBool("Jump", false);
        jumpAnimator16.SetBool("Jump", false);
    }

    public void JumpAction()
    {
       
            jumpAnimator1.SetBool("Jump", true);
            jumpAnimator2.SetBool("Jump", true);
            jumpAnimator3.SetBool("Jump", true);
            jumpAnimator4.SetBool("Jump", true);
            jumpAnimator5.SetBool("Jump", true);
            jumpAnimator6.SetBool("Jump", true);
            jumpAnimator7.SetBool("Jump", true);
            jumpAnimator8.SetBool("Jump", true);
            jumpAnimator9.SetBool("Jump", true);
            jumpAnimator10.SetBool("Jump", true);
            jumpAnimator11.SetBool("Jump", true);
            jumpAnimator12.SetBool("Jump", true);
            jumpAnimator13.SetBool("Jump", true);
            jumpAnimator14.SetBool("Jump", true);
            jumpAnimator15.SetBool("Jump", true);
            jumpAnimator16.SetBool("Jump", true);
            Invoke("JumpEnd", 0.5f);
          
         //   Debug.Log("ButtonPressed");

    }


}
