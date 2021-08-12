using UnityEngine;

namespace Sideview
{
    [KSPAddon(KSPAddon.Startup.EditorAny, false)]
    public class Sideview : MonoBehaviour
    {
        public static void SnapCameraAngle()
        {
            var vec = Camera.main.transform.rotation.eulerAngles;
            vec.x = Mathf.Round(vec.x / 90) * 90;
            vec.y = Mathf.Round(vec.y / 90) * 90;
            vec.z = Mathf.Round(vec.z / 90) * 90;
            Camera.main.transform.eulerAngles = new Vector3(vec.x, vec.y, vec.z);
        }
    }
}