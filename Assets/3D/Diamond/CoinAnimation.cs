using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimation : MonoBehaviour
{
 
    public Animator coinAnimation;
    public AudioSource coinSound;
  

    //Lerp
    [SerializeField] [Range(0f, 4f)] float lerptime;
    [SerializeField] Vector3[] myPositions;
    int posIndex = 0;
    bool lerp = false;

    int length;

    float t = 0f;
 

    // Start is called before the first frame update
    void Start()
    {

        coinAnimation = GetComponent<Animator>();
      
        lerp = false;
        length = myPositions.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (lerp)
            LerpMotion();
        else
            lerp = false;
   

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player"){
        
            coinSound.Play();
            lerp = true;
            coinAnimation.SetBool("Coin",true);

            Invoke("CoinDelete", 1f);



        }
    
  
    }
    private void OnTriggerExit(Collider other)
    {
      
    }


    public void LerpMotion()
    {
        //Lerp Test
        transform.localPosition = Vector3.Lerp(transform.localPosition, myPositions[posIndex], lerptime * Time.deltaTime);

        t = Mathf.Lerp(t, 1f, lerptime * Time.deltaTime);
        if (t > 9f)
        {
            t = 0f;
            posIndex++;
            posIndex = (posIndex >= length) ? 0 : posIndex;
        }
    }

    public void CoinDelete()
    {
        Destroy(this.gameObject);
    }
}
