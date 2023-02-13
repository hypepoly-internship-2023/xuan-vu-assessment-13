using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] protected Renderer EnnermyColor;
    [SerializeField] float speed = 5f;
    [SerializeField] protected Animator anima;
    [SerializeField] protected float raylength;
    private Camera mainCamera;
    bool isStand = false;
    Vector3 pos = new Vector3(0, 1, 9);
    private void Start()
    {
        StartCoroutine(DoCheck());
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && isStand == false)
        {
            if (getNameRay() == "player" && isStand == false)
            {
                DragObj();
            }
            else
            {
                transform.LookAt(pos);
                Move();
            }
        }
    }
    void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void ChangColor()
    {
        if (isStand == false)
            EnnermyColor.material.color = Color.green;
        else
            EnnermyColor.material.color = Color.white;
    }
    string getNameRay()
    {
        string ObjName ="";
        RaycastHit hit;
        Ray rayCast = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(rayCast, out hit, raylength))
        {
             ObjName = hit.transform.name;
        }
        return ObjName;
    }   
    void DragObj()
    {
        mainCamera = Camera.main;
        float Cameraz = mainCamera.WorldToScreenPoint(transform.position).z;
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Cameraz);
        Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(screenPosition);
        Vector3 Pos = new Vector3(NewWorldPosition.x, 1, NewWorldPosition.z);
        transform.position = Pos;
    }
    void doAnimation()
    {
        anima.Play("PlayerAmimation", 0, 0.0f);
    }
    IEnumerator DoCheck()
    {
        while(true)
        {
            isStand = true;
            ChangColor();
            Invoke("doAnimation",0.5f);
            yield return new WaitForSeconds(1.5f);
            isStand = false;
            ChangColor();
            yield return new WaitForSeconds(0.5f);
            yield return null;
        }    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Enermy")
        {
            anima.enabled=false;
        }

    }
}
