using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public bool Active;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (Active)
        {
            Debug.Log("asd");
            BallCountroler tem = collision.gameObject.transform.GetComponent<BallCountroler>();
            if (tem != null)
            {
                tem.Killed();
            }
        }
    }
}