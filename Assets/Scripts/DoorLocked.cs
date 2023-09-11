using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorLocked : MonoBehaviour
{
    public Animator anim;
    private bool textTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("TextAppears", textTrigger);
    }

    // Update is called once per frame


    public void DoorisLockedText()
    {
        if (Singleton.Instance.hasKey == false)
        {
            textTrigger = !textTrigger;
            anim.SetBool("TextAppears", textTrigger);
        }
        else if (Singleton.Instance.hasKey)
        {
            SceneManager.LoadScene("Santa's Workshop");
        }
    }
}
