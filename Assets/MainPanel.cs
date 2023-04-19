using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlatformHit
{
    public class MainPanel : MonoBehaviour
    {
        private Text mScoreTex;

        private void Start()
        {
            mScoreTex = transform.Find("ScoreTex").GetComponent<Text>();
        }
        public void UpdateScoreTex(int score)
        {
            int temp = int.Parse(mScoreTex.text);
            mScoreTex.text = (temp+score).ToString();
        }
    }
}
