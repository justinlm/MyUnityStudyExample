using UnityEngine;

public class OpenURLOnClick : MonoBehaviour
{
	void OnClick ()
	{
		UILabel lbl = GetComponent<UILabel>();
		
		if (lbl != null)
		{
			string url = lbl.GetUrlAtPosition(UICamera.lastWorldPosition);
            if (!string.IsNullOrEmpty(url))
            {
                //ToolLog.Log(LogUser.All, "Ìø×ªÖÁ: " + url);

                Application.OpenURL(url);
            }
		}
	}
}
