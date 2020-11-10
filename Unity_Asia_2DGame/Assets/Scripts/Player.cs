using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject final;

    [Header("鑽石數量")]
    public Text textcount;

    public int count;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送門惹");
        if (collision.name=="傳送門")
        {
            final.SetActive(true);

        }
        if (collision.tag=="鑽石")
        {
            Destroy(collision.gameObject);
            count++;
            textcount.text = "鑽石數量:" + count;
        }
    }

}
