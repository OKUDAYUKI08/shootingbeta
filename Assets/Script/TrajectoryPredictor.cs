using UnityEngine;

public class TrajectoryPredictor : MonoBehaviour
{
    public int numPoints = 50; // 軌跡を描画する点の数
    public float timeBetweenPoints = 0.1f; // 各点の間の時間間隔
    public Rigidbody ballRigidbody; // ボールのRigidbody
    private LineRenderer lineRenderer;

    public GameObject marker;

    Vector3 hitpos;

    void Start()
    {

        // LineRendererを取得
        lineRenderer = GetComponent<LineRenderer>();
        // 初期設定（必要に応じて調整）
        lineRenderer.startWidth = 1.0f;
        lineRenderer.endWidth = 1.0f;
    }

    void Update()
    {
        // 軌跡を描画
        DrawTrajectory();
    }

    void DrawTrajectory()
    {
        // 軌跡のポイントを格納する配列
        Vector3[] points = new Vector3[numPoints];
        // 現在の位置と速度
        Vector3 currentPosition = ballRigidbody.position;
        Vector3 currentVelocity = ballRigidbody.velocity;

        if(gameObject){
            Ray ray=new Ray(currentPosition,currentVelocity);
            if(Physics.Raycast(ray,out RaycastHit hitInfo)){
                Debug.Log(hitInfo.collider.gameObject.name);
                if(hitInfo.collider.gameObject.CompareTag("collition")){
                    hitpos=hitInfo.collider.gameObject.transform.position;
                }
            }
        }



        for (int i = 0; i < numPoints; i++)
        {
            points[i] = currentPosition;
            // 位置の更新
            currentPosition += currentVelocity * timeBetweenPoints;

        }
        
        Instantiate(marker,hitpos,marker.transform.rotation);

        // LineRendererにポイントを設定
        lineRenderer.positionCount = numPoints;
        lineRenderer.SetPositions(points);
    }
}
