using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBubble : MonoBehaviour
{

    public GameObject SpeechBubble;
    public GameObject ThinkBubble;

    private void Update()
    {
        if (InteractableCheck.isInteractable == true)
        {
            SpeechBubble.SetActive(true);
        }
        if (ObjIsInteractable.isInteractable == true)
        {
            ThinkBubble.SetActive(true);
        }
        if (InteractableCheck.isInteractable == false)
        {
            SpeechBubble.SetActive(false);
        }
        if (ObjIsInteractable.isInteractable == false)
        {
            ThinkBubble.SetActive(false);
        }
    }
}
