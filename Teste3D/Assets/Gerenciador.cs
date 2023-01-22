using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Gerenciador : MonoBehaviour
{
    public VideoPlayer[] videos = new VideoPlayer[6];
     

    // Start is called before the first frame update
    void Start()
    {
        foreach (VideoPlayer vd in videos)
        {
            vd.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        videos[0].Play();
        videos[1].Play();
        videos[2].Play();


        videos[3].Stop();
        videos[4].Stop();
        videos[5].Stop();
    }
    
    private void OnTriggerExit(Collider other)
    {
        videos[0].Stop();
        videos[1].Stop();
        videos[2].Stop();


        videos[3].Play();
        videos[4].Play();
        videos[5].Play();
    }


}
