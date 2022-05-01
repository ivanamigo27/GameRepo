using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    void OnCollisionStay2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player" )
		{
			collision.gameObject.GetComponent<CharacterController2D>().ApplyDamage(4f, transform.position);
		}
	}
}
