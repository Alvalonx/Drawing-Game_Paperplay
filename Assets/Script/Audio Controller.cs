using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField]
    private AudioSource m_AudioSource;
    [SerializeField]
    private GameObject audioOn;
    [SerializeField] 
    private GameObject audioOff;
    [SerializeField]
    private bool isPlaying = true;
    public void AudioControl()
    {
        if (isPlaying)
        {
            m_AudioSource.mute = true;
            audioOn.SetActive(false);  
            audioOff.SetActive(true);  
            isPlaying = false;
        }
        else
        {
            m_AudioSource.mute = false;
            audioOn.SetActive(true);   
            audioOff.SetActive(false); 
            isPlaying = true;
        }
    }
    
}
