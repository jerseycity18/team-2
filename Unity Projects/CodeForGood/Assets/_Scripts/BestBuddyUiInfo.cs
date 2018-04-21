using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestBuddyUiInfo : MonoBehaviour
{
    public enum UserType { Buddy, Volunteer }

    public Texture m_maleImage;
    public Color m_maleImageColor;

    public Texture m_femaleImage;
    public Color m_femaleImageColor;

    public UserType m_userType;
    public UILabel m_userNameLabel;
    public UILabel m_ageLabel;
    public UILabel m_descriptionLabel;
    public UILabel m_daysLabel;
    public UITexture m_profileImage;

    public void PopulateUiWithInfo(BestBuddyUserData inputData)
    {
        m_ageLabel.text = inputData.GetAgedAsString();
        m_userNameLabel.text = inputData.Name;
        m_descriptionLabel.text = inputData.Interests;
        m_daysLabel.text = inputData.GetDaysSinceMatchedAsString();

        if (inputData.Gender == 'M')
        {
            m_profileImage.mainTexture = m_maleImage;
            m_profileImage.color = m_maleImageColor;
        }
        else
        {
            m_profileImage.mainTexture = m_femaleImage;
            m_profileImage.color = m_femaleImageColor;
        }
    }
}
