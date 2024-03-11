using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class itemCollector : MonoBehaviour
{
    private int apple = 0;
    [SerializeField] private Text appleText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            apple++;
            appleText.text = "Apple: " + apple;
        }
    }

}
