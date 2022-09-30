using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int fruit = 0;

    [SerializeField] private Text fruitsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Fruit"))
        {
            Destroy(collision.gameObject);
            fruit++;
            fruitsText.text = "Fruits: " + fruit;
        }
    }
}
