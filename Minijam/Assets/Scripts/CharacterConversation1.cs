using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterConversation1 : MonoBehaviour
{
    public NPCConversation demonConversation;
   
    private void Start()
    {
			ConversationManager.Instance.StartConversation(demonConversation);
		
	}
}
