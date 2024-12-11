using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private AudioSource audioSource;

    public int draw;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
        audioSource = GetComponent<AudioSource>();
    }

    public void Setdraw(int objectDraw)
    {
        draw = objectDraw;
    }
    public int Getdraw()
    {
        return draw;
    }
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }
    public AudioSource GetAudioSource()
    {
        return audioSource;
    }
}
