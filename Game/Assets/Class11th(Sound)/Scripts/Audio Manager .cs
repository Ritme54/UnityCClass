using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] static AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
public static void Emit(AudioClip AudioClip) // static 메서드는 static 멤버만 접근 가능
    {
      //  audioSource.clip = AudioClip; 이 방식은 재생중인 사운드가 끊기게 된다.
        audioSource.PlayOneShot(AudioClip); // 이 방식은 재생중인 사운드가 끊기지 않는다.
        Debug.Log("Play");
        
    }
 

}

