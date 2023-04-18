using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PlatformHit
{
    public class GamePassPanel : MonoBehaviour
    {
        private void Start()
        {
            transform.Find("ResetGameBtn").GetComponent<Button>().onClick.AddListener(() =>
            {
                SceneManager.LoadScene("SampleScene");
            });
        }
    }
}

