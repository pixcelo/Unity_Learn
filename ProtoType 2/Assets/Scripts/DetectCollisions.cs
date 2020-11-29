using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // 衝突判定を行って、ゲームオブジェクトを破壊する
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
