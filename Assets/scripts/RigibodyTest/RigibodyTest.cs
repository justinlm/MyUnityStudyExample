using UnityEngine;
using System.Collections;

public class RigibodyTest : MonoBehaviour {

    Rigidbody m_Rigidbody;
    public float liftAngle = 0;
    public float addAngle = 1.0f;
	// Use this for initialization
	void Start () {
        m_Rigidbody = this.transform.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        float dt = Time.fixedDeltaTime;

        UpdateJumpingRotation(addAngle, dt);
    }

    void UpdateJumpingRotation(float coeff, float dt)
    {
        //Quaternion.LookRotation(rotTan)
        //创建一个旋转，沿着forward, 并且头部沿着upwards 的约束注视。也就是建立一个旋转，使视角朝向forward，顶部朝向upwards。
        //使用Rigidbody.MoveRotation来旋转刚体，带有刚体的插值设置。在任意两帧之间平滑过渡
        Vector3 rotTan = new Vector3(gameObject.transform.forward.x, liftAngle, gameObject.transform.forward.z);
        m_Rigidbody.MoveRotation(Quaternion.LookRotation(rotTan));
        liftAngle += dt * coeff;
        liftAngle = Mathf.Clamp(liftAngle, 0.0f, 0.5f);
    }
}
