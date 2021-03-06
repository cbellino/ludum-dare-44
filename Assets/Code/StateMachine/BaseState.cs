using System;
using UnityEngine;

public abstract class BaseState
{
	protected GameObject gameObject;
	protected Transform transform;

	public BaseState(GameObject gameObject)
	{
		this.gameObject = gameObject;
		this.transform = gameObject.transform;
	}

	public virtual void OnStart() { }

	public abstract Type Tick();

	public virtual void OnEnd() { }
}
