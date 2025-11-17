using UnityEngine;
using UnityEngine.Playables;

public class Trigger_Cube : MonoBehaviour
{

    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            timeline.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timeline.Stop();
        }
    }
}
