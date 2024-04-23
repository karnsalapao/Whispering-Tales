using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject[] turnOffObjects;
    

    public void StartStory(AudioClip clip)
    {
        if (audioSource.isPlaying)
            return;
        audioSource.PlayOneShot(clip);
        ToggleObjects(false);
        StartCoroutine(WaitTheEnd());
    }

    private IEnumerator WaitTheEnd()
    {
        yield return null;
        yield return new WaitUntil(() => !audioSource.isPlaying);
        ToggleObjects(true);
    }

    public void ToggleObjects(bool turnOn)
    {
        foreach (var toObject in turnOffObjects)
        {
            toObject.SetActive(turnOn);
        }
    }
}
