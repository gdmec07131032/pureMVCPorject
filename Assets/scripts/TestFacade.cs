using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;

public class TestFacade : Facade {

	public TestFacade(GameObject canvas)
    {
        RegisterCommand(NotificationConstant.LevelUp, typeof(TestCommand));
        RegisterMediator(new TestMediator(canvas,null));
        RegisterProxy(new TestProxy());
    }
}
