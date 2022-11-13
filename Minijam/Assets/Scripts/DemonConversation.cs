using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DemonConversation : MonoBehaviour
{
    public NPCConversation demonConversation;
    private void OnCollisionEnter2D(Collision2D collision)
    {
	    
        ConversationManager.Instance.StartConversation(demonConversation);
		StartCoroutine(waiter());
	}
	IEnumerator waiter()
	{
		yield return new WaitForSecondsRealtime(2);

	}
}

