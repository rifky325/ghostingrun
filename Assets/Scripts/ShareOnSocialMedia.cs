using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ShareOnSocialMedia : MonoBehaviour
{
    [SerializeField] GameObject SharePanel;
    [SerializeField] Text txtPanelScore;
    [SerializeField] Text txtHomeScore;

    public void ShareScore()
    {
        txtPanelScore.text = txtHomeScore.text;
        SharePanel.SetActive(true);
        StartCoroutine("TakeScreenShotAndShare");
    }

    IEnumerator TakeScreenShotAndShare()
    {
        yield return new WaitForEndOfFrame();
        Texture2D tx = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        tx.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        tx.Apply();

        string path = Path.Combine(Application.temporaryCachePath, "sharedImage.png");
        File.WriteAllBytes(path, tx.EncodeToPNG());

        Destroy(tx);

        new NativeShare()
            .AddFile(path)
            .SetSubject("This is my score")
            .SetText("share your score with your friends")
            .Share();

        SharePanel.SetActive(false);
    }
}
