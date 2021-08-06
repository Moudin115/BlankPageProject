using Yarn.Unity;
using UnityEngine;

public class DialogueControlls : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text dialogue = null;

    private DialogueUI dialogueUI = null;
    private TMPro.TMP_Text[] options;

    private int optionSize;
    private int currentOption;

    private bool isOptionDisplayed;
    bool axisInUse = false;
    // Start is called before the first frame update
    void Start()
    {
        // Flag needed to check when the Options are displayed to enable the controls for them
        isOptionDisplayed = false;
        // Get a reference to the DialogueUI
        dialogueUI = FindObjectOfType<DialogueUI>();
        // Save the number of options available
        optionSize = dialogueUI.optionButtons.Count;
        // Initialize the current index
        currentOption = 0;
        // Initialize the array size to the number of options
        options = new TMPro.TMP_Text[optionSize];
        // Get the TextMeshPro Text components from the option buttons in the DialogueUI 
        for (int i = 0; i < optionSize; i++)
        {
            options[i] = dialogueUI.optionButtons[i].GetComponentInChildren<TMPro.TMP_Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        ControlOptions();
        
    }

    private void ControlOptions()
    {
        if (isOptionDisplayed)
        {
            ChangeOption();
            SelectOption();
        }
        else
        {
            SkipDialogue();
        }
    }

    public void ChangeOption()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput < 0)
        {
            if (!axisInUse)
            {
                currentOption = (currentOption + 1) % optionSize;
                dialogue.SetText(options[currentOption].text);
                axisInUse = true;
            }
        }
        if (horizontalInput > 0)
        {
            if (!axisInUse)
            {
                //Move to the previous option
                if (currentOption == 0)
                    currentOption = optionSize - 1;
                else
                    currentOption = (Mathf.Abs(currentOption - 1) % optionSize);

                dialogue.SetText(options[currentOption].text);
                axisInUse = true;
            }
        }
        else if (horizontalInput == 0)
        {
            axisInUse = false;
        }
    }

    private void SkipDialogue()
    {
        //change Keycode later
        if (Input.GetButtonDown("Interact"))
        {
            //Time.timeScale = 0f;
            dialogueUI.MarkLineComplete();
        }
    }

    private void SelectOption()
    {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            //Time.timeScale = 1f;
            dialogueUI.SelectOption(currentOption);
            ResetCurrentOption();
        }
        if (Input.GetButtonDown("Interact"))
        {
            //Time.timeScale = 1f;
            dialogueUI.SelectOption(currentOption);
            ResetCurrentOption();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Time.timeScale = 1f;
            dialogueUI.SelectOption(currentOption);
            ResetCurrentOption();
        }
    }

    private void ResetCurrentOption()
    {
        currentOption = 0;
    }

    public void SetStartingOption()
    {
        dialogue.SetText(options[0].text);
    }

    public void SetOptionDisplayed(bool flag)
    {
        isOptionDisplayed = flag;
    }
}