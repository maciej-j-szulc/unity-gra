using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private bool collected = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && collected == false)
        {
            if (gameObject.tag == "PickUpBronze")
            {
                Score.scoreValue += 10;
            }
            if(gameObject.tag == "PickUpSilver")
            {
                Score.scoreValue += 50;
            }
            if(gameObject.tag =="PickUpGold")
            {
                Score.scoreValue += 100;
            }
            Destroy(gameObject);
            collected = true;
        }
    }
}
