using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundCon : MonoBehaviour
{
    public AudioClip[] aClips;
    public AudioSource myAudioSource;
    string btnName;
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit)){
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "keyC":
                        myAudioSource.clip = aClips[0];
                        myAudioSource.Play();
                        break;
                    case "keyD":
                        myAudioSource.clip = aClips[1];
                        myAudioSource.Play();
                        break;
                    case "keyE":
                        myAudioSource.clip = aClips[2];
                        myAudioSource.Play();
                        break;
                    case "keyF":
                        myAudioSource.clip = aClips[3];
                        myAudioSource.Play();
                        break;
                    case "keyG":
                        myAudioSource.clip = aClips[4];
                        myAudioSource.Play();
                        break;
                    case "keyA":
                        myAudioSource.clip = aClips[5];
                        myAudioSource.Play();
                        break;
                    case "keyB":
                        myAudioSource.clip = aClips[6];
                        myAudioSource.Play();
                        break;
                    case "keyC1":
                        myAudioSource.clip = aClips[7];
                        myAudioSource.Play();
                        break;
                    case "keyD1":
                        myAudioSource.clip = aClips[8];
                        myAudioSource.Play();
                        break;
                    case "keyF1":
                        myAudioSource.clip = aClips[9];
                        myAudioSource.Play();
                        break;
                    case "keyG1":
                        myAudioSource.clip = aClips[10];
                        myAudioSource.Play();
                        break;
                    case "keyA1":
                        myAudioSource.clip = aClips[11];
                        myAudioSource.Play();
                        break;
                    case "keyCh":
                        myAudioSource.clip = aClips[12];
                        myAudioSource.Play();
                        break;
                    case "keyDh":
                        myAudioSource.clip = aClips[13];
                        myAudioSource.Play();
                        break;
                    case "keyEh":
                        myAudioSource.clip = aClips[14];
                        myAudioSource.Play();
                        break;
                    case "keyFh":
                        myAudioSource.clip = aClips[15];
                        myAudioSource.Play();
                        break;
                    case "keyCh1":
                        myAudioSource.clip = aClips[16];
                        myAudioSource.Play();
                        break;
                    case "keyDh1":
                        myAudioSource.clip = aClips[17];
                        myAudioSource.Play();
                        break;
                    default:
                        break;

                }
            }
        }

    }
}
