﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.MonoBehaviour
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>MonoBehaviour is the base class every script derives from.</para>
  /// </summary>
  [RequiredByNativeCode]
  public class MonoBehaviour : Behaviour
  {
    /// <summary>
    ///   <para>Disabling this lets you skip the GUI layout phase.</para>
    /// </summary>
    public bool useGUILayout { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public MonoBehaviour();

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void Internal_CancelInvokeAll();

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private bool Internal_IsInvokingAll();

    /// <summary>
    ///   <para>Invokes the method methodName in time seconds.</para>
    /// </summary>
    /// <param name="methodName"></param>
    /// <param name="time"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void Invoke(string methodName, float time);

    /// <summary>
    ///   <para>Invokes the method methodName in time seconds, then repeatedly every repeatRate seconds.</para>
    /// </summary>
    /// <param name="methodName"></param>
    /// <param name="time"></param>
    /// <param name="repeatRate"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void InvokeRepeating(string methodName, float time, float repeatRate);

    /// <summary>
    ///   <para>Cancels all Invoke calls on this MonoBehaviour.</para>
    /// </summary>
    public void CancelInvoke()
    {
      this.Internal_CancelInvokeAll();
    }

    /// <summary>
    ///   <para>Cancels all Invoke calls with name methodName on this behaviour.</para>
    /// </summary>
    /// <param name="methodName"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void CancelInvoke(string methodName);

    /// <summary>
    ///   <para>Is any invoke on methodName pending?</para>
    /// </summary>
    /// <param name="methodName"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public bool IsInvoking(string methodName);

    /// <summary>
    ///   <para>Is any invoke pending on this MonoBehaviour?</para>
    /// </summary>
    public bool IsInvoking()
    {
      return this.Internal_IsInvokingAll();
    }

    /// <summary>
    ///   <para>Starts a coroutine.</para>
    /// </summary>
    /// <param name="routine"></param>
    public Coroutine StartCoroutine(IEnumerator routine)
    {
      return this.StartCoroutine_Auto(routine);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public Coroutine StartCoroutine_Auto(IEnumerator routine);

    /// <summary>
    ///   <para>Starts a coroutine named methodName.</para>
    /// </summary>
    /// <param name="methodName"></param>
    /// <param name="value"></param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value);

    /// <summary>
    ///   <para>Starts a coroutine named methodName.</para>
    /// </summary>
    /// <param name="methodName"></param>
    /// <param name="value"></param>
    [ExcludeFromDocs]
    public Coroutine StartCoroutine(string methodName)
    {
      object obj = (object) null;
      return this.StartCoroutine(methodName, obj);
    }

    /// <summary>
    ///   <para>Stops the first coroutine named methodName, or the coroutine stored in routine running on this behaviour.</para>
    /// </summary>
    /// <param name="methodName">Name of coroutine.</param>
    /// <param name="routine">Name of the function in code.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void StopCoroutine(string methodName);

    /// <summary>
    ///   <para>Stops the first coroutine named methodName, or the coroutine stored in routine running on this behaviour.</para>
    /// </summary>
    /// <param name="methodName">Name of coroutine.</param>
    /// <param name="routine">Name of the function in code.</param>
    public void StopCoroutine(IEnumerator routine)
    {
      this.StopCoroutineViaEnumerator_Auto(routine);
    }

    public void StopCoroutine(Coroutine routine)
    {
      this.StopCoroutine_Auto(routine);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal void StopCoroutineViaEnumerator_Auto(IEnumerator routine);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal void StopCoroutine_Auto(Coroutine routine);

    /// <summary>
    ///   <para>Stops all coroutines running on this behaviour.</para>
    /// </summary>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void StopAllCoroutines();

    /// <summary>
    ///   <para>Logs message to the Unity Console (identical to Debug.Log).</para>
    /// </summary>
    /// <param name="message"></param>
    public static void print(object message)
    {
      Debug.Log(message);
    }
  }
}
