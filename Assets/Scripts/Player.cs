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

    // Start is called before the first frame update
    void Start()
    {
        
        walkFx = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (walkFx != null)
        {

            if (Input.GetKey(KeyCode.W))
            {
                AudioStep();
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }

            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                speed += 3.5f;
                timeStep -= 0.3f;
            }

            if(Input.GetKeyUp(KeyCode.LeftShift))
            {
                speed -= 3.5f;
                timeStep += 0.3f;
            }

            if (Input.GetKeyUp(KeyCode.W))
            {
                timingStep = 0;
            }
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
