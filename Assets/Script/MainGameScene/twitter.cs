using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class twitter : MonoBehaviour
{
    public void OnClickTwitterButton()
    {
        //urlの作成
        string esctext = UnityWebRequest.EscapeURL("例）やたー\n\nhttps://unityroom.com/games/3dbreakingblocks");
        string esctag = UnityWebRequest.EscapeURL("3Dブロック崩しゲーム");
        string url = "https://x.com/intent/tweet?text=" + esctext + "&hashtags=" + esctag;

        //Twitter投稿画面の起動
        Application.OpenURL(url);
    }
}
