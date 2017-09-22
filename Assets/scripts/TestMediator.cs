using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using UnityEngine.UI;
using System;
using PureMVC.Interfaces;

public class TestMediator : Mediator
{

    public new const string NAME = "TestMediator";

    private Text levelText;
    private Button levelUpButton;

    public TestMediator(GameObject root,object viewComponent) : base(NAME,viewComponent)
    {
        levelText = GameUtility.GetChildCommponent<Text>(root, "lv/num");
        levelUpButton = GameUtility.GetChildCommponent<Button>(root, "lvUpButton");

        levelUpButton.onClick.AddListener(OnClickLevelUpButton);
    }

    private void OnClickLevelUpButton()
    {
        SendNotification(NotificationConstant.LevelUp);
    }

    public override IList<string> ListNotificationInterests()
    {
        return new List<string> {
            NotificationConstant.LevelChange
        };
    }
    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case NotificationConstant.LevelChange:
                CharacterInfo ci = notification.Body as CharacterInfo;
                levelText.text = ci.Level.ToString();
                break;
            default:
                break;
        }
    }
}
