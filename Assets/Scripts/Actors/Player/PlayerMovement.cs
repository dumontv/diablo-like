using System;
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed = 3.5f;

    private Rigidbody2D _rigidbody2D;
    private InputManager _inputManager;

	private void Start()
	{
	    _rigidbody2D = GetComponent<Rigidbody2D>();
	    _inputManager = GetComponent<InputManager>();
	    _inputManager.OnMouseLeftClick += OnMouseLeftClick;
	}

    private void OnMouseLeftClick(Vector2 pos)
    {
        StopAllCoroutines();
        StartCoroutine(MoveToClickCoroutine(pos));
    }

    private IEnumerator MoveToClickCoroutine(Vector2 pos)
    {       
        while ((Vector2) transform.position != pos)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos, _playerSpeed * Time.deltaTime);
            yield return null;
        }           
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == GameObjectTags.GetEnemyTag())
        {
            StopAllCoroutines();
        }
    }
}
