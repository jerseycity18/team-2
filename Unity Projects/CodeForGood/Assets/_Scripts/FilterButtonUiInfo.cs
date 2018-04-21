using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterButtonUiInfo : MonoBehaviour
{
    public UISprite m_background;
    public UILabel m_nameLabel;
    public UILabel m_userTypeLabel;
    public UILabel m_daysLabel;

    private BestBuddyUserData m_userData;

    public void PopulateUiWithInfo(BestBuddyUserData inputUserData)
    {
        m_userData = inputUserData;
        m_nameLabel.text = inputUserData.Name;
        m_userTypeLabel.text = inputUserData.GetUserTypeAsString();
        m_daysLabel.text = inputUserData.GetDaysSinceMatchedAsString();
    }

    public void SendRequest()
    {
        //TODO sendRequest
    }
}
