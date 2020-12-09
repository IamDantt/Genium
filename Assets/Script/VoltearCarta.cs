using UnityEngine;
[ExecuteInEditMode]

public class VoltearCarta : MonoBehaviour
{
    [SerializeField]
    private GameObject frenteCarta;
    [SerializeField]
    private GameObject atrasCarta;

    protected void Update()
    {
        Vector3 a = (Camera.main.transform.position - transform.position);
        Vector3 b = -transform.forward;
        float rotAngle = (Vector3.Dot(a, b) / (a.magnitude * b.magnitude)) * Mathf.Rad2Deg;

        bool back = rotAngle < 0;

        frenteCarta.SetActive(!back);
        atrasCarta.SetActive(back);
    }

}
