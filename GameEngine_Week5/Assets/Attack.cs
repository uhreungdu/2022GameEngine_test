using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator anim;

    private bool attacking;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnAttack()
    {
        if(!attacking)
            StartCoroutine(AttackCourutine());
    }
    IEnumerator AttackCourutine()
    {
        anim.SetBool("isAttack",true);
        yield return new WaitForSeconds(1.5f);
        anim.SetBool("isAttack",false);
        attacking = false;
    }
}
