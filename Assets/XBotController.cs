using UnityEngine;

public class XBotController : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bool dancing = anim.GetBool("Dance");
            anim.SetBool("Dance", !dancing);
        }
    }
}
