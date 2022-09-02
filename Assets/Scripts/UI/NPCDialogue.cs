using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private string[] lines;

    [SerializeField] private float textSpeed;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        dialogueText.text = string.Empty;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dialogueText.text.Equals(lines[index]))
                NextLine();
            else
            {
                StopAllCoroutines();
                dialogueText.text = lines[index];
            }
        }
        
    }
    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLineSpeed());
    }

    IEnumerator TypeLineSpeed()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed); 
        }
    }

    void NextLine()
    {
        if(index < lines.Length -1)
        {
            index++;
            dialogueText.text = string.Empty;
            StartCoroutine(TypeLineSpeed());
        }
        else
        {
            dialogueText.text = string.Empty;
            this.gameObject.SetActive(false);
        }
    }

    public void EndDialogue()
    {
        dialogueText.text = string.Empty;
        this.gameObject.SetActive(false);
        StopAllCoroutines();
    }

}
