﻿using XQ.SDK.EventArgs;

namespace XQ.SDK.Interface
{
    /// <summary>
    ///     群事件接口
    /// </summary>
    public interface IGroupEvent : IProcess
    {
        /// <summary>
        ///     当在派生类中重写时, 处理 群事件 回调
        /// </summary>
        /// <param name="e">附加的事件参数</param>
        void GroupEvent(XqGroupEventArgs e);
    }
}