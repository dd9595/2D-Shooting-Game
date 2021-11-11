using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private float maxHP = 10;
    private float currentHP;
    private SpriteRenderer spriteRenderer;
	private PlayerController playerController;

	public float MaxHP => maxHP;
	public float CurrentHP => currentHP;

	private void Awake()
	{
		currentHP = maxHP;
		spriteRenderer = GetComponent<SpriteRenderer>();
		playerController = GetComponent<PlayerController>();
	}

	public void TakeDamage(float _damage)
	{
		currentHP -= _damage;

		StopCoroutine("HitColorAnimation");
		StartCoroutine("HitColorAnimation");

		if ( currentHP <= 0 )
		{
			playerController.OnDie();
		}
	}

	private IEnumerator HitColorAnimation()
	{
		spriteRenderer.color = Color.red;

		yield return new WaitForSeconds(0.1f);

		spriteRenderer.color = Color.white;
	}
}
