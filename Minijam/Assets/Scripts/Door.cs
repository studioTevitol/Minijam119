using UnityEngine;

public class Door : MonoBehaviour
{
	[SerializeField] private Transform destination;

	public Transform GetDestination()
	{
		return destination;
	}
}