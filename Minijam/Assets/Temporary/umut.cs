using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using TMPro;
using UnityEngine;

public class umut : MonoBehaviour
{
    public NPCConversation Conversation;
	public CharacterMovement player;
	


	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			ConversationManager.Instance.StartConversation(Conversation);
			Debug.Log("Içerde");
		}
		
	   
	}
	private void Update()
	{
		player.isInDialogue = ConversationManager.Instance.IsConversationActive;
		
	}







}
