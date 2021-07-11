using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

public class DialogueMover : MonoBehaviour
{
    private DialogueUI dialogueUI;
    private Camera cam;

    private Transform DialoguePos;

    // Start is called before the first frame update
    void Awake()
    {
        // Retrieve references for the DialogueUI and Camera
        dialogueUI = FindObjectOfType<DialogueUI>();
        cam = Camera.main;
    }

    private void Update()
    {
        // If the Camera changes view, this ensures that the Dialogue Bubble position
        // get recalculated based on the new Camera view, every frame
        SetDialogueOnTalkingCharacter();
    }

    // Retrieve the character who's talking from the text
    public void SetDialogueOnTalkingCharacter()
    {
        GameObject character;
        string line, name;

        // Get the dialogue line
        line = dialogueUI.GetLineText();
        // Search for the character who's talking
        if (line.Contains(":"))
            name = line.Substring(0, line.IndexOf(":"));
        else
            name = "Player";
        // Search the GameObject of the character in the Scene
        character = GameObject.Find(name);
        // Sets the dialogue position
        
        SetDialoguePosition(character);
    }

    private void SetDialoguePosition(GameObject character)
    {
        // Retrieve the position where the top part of the sprite is in the world
            DialoguePos = character.transform.Find("DialoguePos");

        /*float characterSpriteHeight = character.GetComponent<BoxCollider2D>().bounds.size.y + 0.5f;
        float characterSpriteWidth = character.transform.position.x;

        Scene currentScene = SceneManager.GetActiveScene();*/


            Vector2 characterPosition = DialoguePos.transform.position;
            SetPos(characterPosition);
        
        
        
        // Set the DialogueBubble position to the sprite top location in Screen Space
        
    }
    private void SetPos(Vector2 characterPosition)
    {
        this.transform.position = cam.WorldToScreenPoint(characterPosition);
    }
}