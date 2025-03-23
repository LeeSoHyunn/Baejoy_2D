using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{// Start is called before the first frame update
    public float moveSpeed;
    Animator anim;
    Rigidbody2D rigid;
    void Start()    
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        if (inputX != 0 || inputY != 0)
            anim.SetBool("ismove", true);
        else
            anim.SetBool("ismove", false);

        anim.SetFloat("inputx", inputX);
        anim.SetFloat("inputy", inputY);
        transform.Translate(new Vector2(inputX,inputY)*Time.deltaTime*moveSpeed);

        rigid.velocity = new Vector2(inputX, inputY);
    }
}
