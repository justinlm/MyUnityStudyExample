using UnityEngine;

using System.Collections;

public class AIFollowUseBoxCollider : MonoBehaviour
{

    public GameObject m_FollowTarget = null;

    public GameObject missile;

    public float missileSpeed = 6f;

    public float missileRotateSpeed = 4f;

    bool whehterShooted = false;

    float distance;

    float collisionDistance;

    // Use this for initialization

    void Start()
    {
        missile = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))//按下S 发射导弹
        {
            whehterShooted = true;
        }

        if (whehterShooted && missile != null)
        {
            distance = Vector3.Distance(m_FollowTarget.transform.position, missile.transform.position);

            ////导弹朝向人  法一
            //missile.transform.LookAt(man.transform);          

            //导弹朝向人  法二            
            Quaternion missileRotation = Quaternion.LookRotation(m_FollowTarget.transform.position - missile.transform.position, Vector3.up);
            //missile.transform.rotation = Quaternion.Slerp(missile.transform.rotation, missileRotation, Time.deltaTime * missileRotateSpeed);
            missile.transform.rotation = missileRotation;


            //导弹朝向人   法三            
            //Vector3 targetDirection = man.transform.position - missile.transform.position;
            //float angle = Vector3.Angle(targetDirection,missile.transform.forward);//取得两个向量间的夹角
            //print("angle:"+angle.ToString());
            //if (angle > 5)
            //{
            //    missile.transform.Rotate(Vector3.up, angle);
            //}

            missile.transform.Translate(Vector3.forward * Time.deltaTime * missileSpeed);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("========================:" + collision.collider.name);
    }
}