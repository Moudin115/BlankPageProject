using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBubble : MonoBehaviour
{

    public GameObject SpeechBubble;

    private void Update()
    {
        if (InteractableCheck.isInteractable == true)
        {
            SpeechBubble.SetActive(true);
        }

        if (InteractableCheck.isInteractable == false)
        {
            SpeechBubble.SetActive(false);
        }
    }
}
