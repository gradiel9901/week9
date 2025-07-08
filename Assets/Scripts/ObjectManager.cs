using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject objPrefab;
    public Vector3 objPosition;

    private void Awake()
    {
        GameObject obj = Instantiate(objPrefab, new Vector3(Random.Range(-100, -100), Random.Range(-100, 100), objPrefab.transform.position.z), Quaternion.identity);

        objPosition = obj.transform.position;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
