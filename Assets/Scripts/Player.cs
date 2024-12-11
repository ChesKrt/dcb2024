using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{

    AudioSource walkFx;
    public float timeStep = 0.75f;
    public float timingStep;
    public AudioClip stepFbx;
    public float speed;
    Animator _mAnim;

    // Start is called before the first frame update
    void Start()
    {
        
        walkFx = GetComponent<AudioSource>();
        _mAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKey(KeyCode.W))
          {
             AudioStep();
             _mAnim.SetBool("Walk", true);
             transform.Translate(Vector3.forward * Time.deltaTime * speed);
          }

          if(Input.GetKeyDown(KeyCode.LeftShift))
          {
             speed += 3.5f;
             timeStep -= 0.3f;
             _mAnim.SetBool("Run", true);
          }

          if(Input.GetKeyUp(KeyCode.LeftShift))
          {
            speed -= 3.5f;
            timeStep += 0.3f;
            _mAnim.SetBool("Run", false);
          }

         if (Input.GetKeyUp(KeyCode.W))
         {
            timingStep = 0;
            _mAnim.SetBool("Walk", false);
         }
    }

    void AudioStep()
    {
        timingStep += Time.deltaTime;
        if (timingStep > timeStep)
        {
            walkFx.PlayOneShot(stepFbx);
            timingStep = 0;
        }
    }

}
