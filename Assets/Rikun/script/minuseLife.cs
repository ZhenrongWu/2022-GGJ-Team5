
using UnityEngine;
using UnityEngine.UI;

public class minuseLife2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(() => show_player_health2.isDamage=true);
    }

}
