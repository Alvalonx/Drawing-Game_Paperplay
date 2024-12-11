using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource audioSource = GameManager.Instance.GetAudioSource();
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
            audioSource.mute = true;
            audioOn.SetActive(false);  
            audioOff.SetActive(true);  
            isPlaying = false;
        }
        else
        {
            audioSource.mute = false;
            audioOn.SetActive(true);   
            audioOff.SetActive(false); 
            isPlaying = true;
        }
    }
    
}
