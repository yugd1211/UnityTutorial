using UnityEngine;

public class Outline : MonoBehaviour
{
	public Character target;
	public bool isAligned;
	private GameManager _gameManager;
	
	private void Awake()
	{
		isAligned = false;
	}
	private void Start()
	{
		_gameManager = GameManager.Instance;
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (!other.CompareTag("Player") || other.gameObject.GetComponent<PlayerController>().me != target)
			return;
		isAligned = true;
		_gameManager.CheckOutlineAligned();
	}
	private void OnTriggerExit(Collider other)
	{
		if (!other.CompareTag("Player") || other.gameObject.GetComponent<PlayerController>().me != target)
			return;
		isAligned = false;
		_gameManager.CheckOutlineAligned();
	}
}
