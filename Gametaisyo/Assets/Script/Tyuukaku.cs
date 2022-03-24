using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyuukaku : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] Transform target;

	// カーソル
	[SerializeField] Transform cursor;

	// Update is called once per frame
	void Update()
	{
		cursor.LookAt(target);
	}
}
