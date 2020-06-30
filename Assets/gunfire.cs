using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunfire : MonoBehaviour
{
    private Animator gunAnim;
    private AudioSource audSor;
    [SerializeField]
    private AudioClip[] clips = null;
    // Start is called before the first frame update
    void Start()
    {
        gunAnim = GetComponent<Animator>();
        audSor= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            AudioClip clip = GetRandomClip();
            audSor.pitch = (Random.Range(0.9f, 1.1f));
            audSor.PlayOneShot(clip);
            gunAnim.SetTrigger("fire");
            //gunAnim.ResetTrigger("fire");
            
        }
    }

    private AudioClip GetRandomClip()
    {
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }
}
