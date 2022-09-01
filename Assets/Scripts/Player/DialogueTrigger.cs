using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    [SerializeField] private NPCDialogue dialogueNPC;
    [SerializeField] private GameObject NPC;

    void Update()
    {
        
        CheckDistance();
    }

    void CheckDistance()
    {
        if (Vector3.Distance(this.gameObject.transform.position, NPC.transform.position) < 2.5f)
        {
            if (Input.GetKeyDown(KeyCode.E) && !dialogueNPC.gameObject.activeSelf)
            {
                dialogueNPC.gameObject.SetActive(true);
                dialogueNPC.StartDialogue();
            }

        }
        else
            dialogueNPC.EndDialogue();

    }

}
