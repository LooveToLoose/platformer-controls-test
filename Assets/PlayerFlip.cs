using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    Vector2 v2LocalPosStart;

	void Start ()
    {
        v2LocalPosStart = transform.localPosition;
    }
	
	void Update ()
    {
        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.01f)
            transform.localPosition = new Vector2(v2LocalPosStart.x * Mathf.Sign(Input.GetAxisRaw("Horizontal")), transform.localPosition.y);
    }
}
