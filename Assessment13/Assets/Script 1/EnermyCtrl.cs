using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnermyCtrl : MonoBehaviour
{
    [SerializeField] protected Renderer EnnermyColor;
    [SerializeField] float speed = 5f;
    [SerializeField] protected Animator anima;
    [SerializeField] TextMeshProUGUI RunTime;
    [SerializeField] protected TimeToPlay GameManager;
    bool isStand = true;
    Vector3 pos = new Vector3(-10, 1, 0);
    float dist;
    private void Start()
    {
        transform.LookAt(pos);
        ChangColor();
        StartCoroutine(StartCheck());
        
    }
    public void Update()
    {
        dist = Vector3.Distance(transform.position, pos);
        if(dist < 1f)
        {
            isStand = true;
            ChangColor();
            StartCoroutine(DoCheck());
            turning();
        }
        if(isStand==false)
            patrol();
    }
    void ChangColor()
    {
        if (isStand == false)
            EnnermyColor.material.color = Color.red;
        else
            EnnermyColor.material.color = Color.white;
    }
    void patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }    
    void turning()
    {
        pos.x *= -1;
        transform.LookAt(pos);
    }
    void doAnimation()
    {
        anima.Play("Enermy",0,0.0f);
    }
    IEnumerator DoCheck()
    {
        Invoke("doAnimation", 1f);
        yield return new WaitForSeconds(2f);
        isStand = false;
        ChangColor();
    }
    IEnumerator StartCheck()
    {
        yield return new WaitForSeconds(2f);
        isStand = false;
        ChangColor();
    }    
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            GameManager.GameOver();
        }    
            
    }
}
