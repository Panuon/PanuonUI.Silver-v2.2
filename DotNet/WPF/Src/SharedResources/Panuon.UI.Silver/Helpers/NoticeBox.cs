﻿using Panuon.UI.Silver.Configurations;
using Panuon.UI.Silver.Internal.Controls;
using Panuon.UI.Silver.Internal.Implements;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Threading;

namespace Panuon.UI.Silver
{
    public static class NoticeBox
    {
        #region Fields
        private static NoticeBoxWindow _noticeWindow;

        private static Thread _thread;
        #endregion

        #region Methods
        public static INoticeHandler Show(string message)
        {
            return Show(message: message, canClose: true);
        }

        public static INoticeHandler Show(string message, bool canClose)
        {
            return Show(message: message, caption: null, canClose: canClose);
        }

        public static INoticeHandler Show(string message, bool canClose, MessageBoxIcon icon)
        {
            return Show(message: message, caption: null, canClose: canClose, icon: icon, duration: null, imageIcon: null);
        }

        public static INoticeHandler Show(string message, bool canClose, ImageSource icon)
        {
            return Show(message: message, caption: null, canClose: canClose, imageIcon: icon, duration: null, icon: MessageBoxIcon.None);
        }

        public static INoticeHandler Show(string message, string caption)
        {
            return Show(message: message, caption: caption, canClose: true);
        }

        public static INoticeHandler Show(string message, string caption, MessageBoxIcon icon)
        {
            return Show(message: message, caption: caption, canClose: true, icon: icon, duration: null, imageIcon: null);
        }

        public static INoticeHandler Show(string message, string caption, ImageSource icon)
        {
            return Show(message: message, caption: caption, canClose: true, icon: MessageBoxIcon.None, imageIcon: icon, duration: null);
        }

        public static INoticeHandler Show(string message, int? duration)
        {
            return Show(message: message, caption: null, canClose: true, duration: duration);
        }

        public static INoticeHandler Show(string message, int? duration, MessageBoxIcon icon)
        {
            return Show(message: message, caption: null, canClose: true, duration: duration, icon: icon, imageIcon: null);
        }

        public static INoticeHandler Show(string message, int? duration, ImageSource icon)
        {
            return Show(message: message, caption: null, canClose: true, duration: duration, icon: MessageBoxIcon.None, imageIcon: icon);
        }

        public static INoticeHandler Show(string message, string caption, bool canClose)
        {
            return Show(message: message, caption: caption, canClose: canClose, duration: null);
        }

        public static INoticeHandler Show(string message, string caption, bool canClose, int? duration)
        {
            return Show(message: message, caption: caption, canClose: canClose, icon: MessageBoxIcon.None, duration: duration, imageIcon: null);
        }

        public static INoticeHandler Show(string message, string caption, bool canClose, MessageBoxIcon icon, ImageSource imageIcon, int? duration)
        {
            var setting = NoticeBoxSettings.Setting;
            var animationEase = setting.AnimationEase;
            var animationDuration = setting.AnimationDuration;
            var cardStyle = setting.NoticeBoxItemStyle;

            if (_noticeWindow == null)
            {
                if (setting.CreateOnNewThread)
                {
                    var autoReset = new AutoResetEvent(false);
                    _thread = new Thread(() =>
                    {
                        _noticeWindow = new NoticeBoxWindow(animationEase, animationDuration);
                        _noticeWindow.Closed += delegate
                        {
                            _noticeWindow.Dispatcher.InvokeShutdown();
                        };
                        _noticeWindow.Show();
                        autoReset.Set();
                        Dispatcher.Run();
                    });
                    _thread.SetApartmentState(ApartmentState.STA);
                    _thread.IsBackground = true;
                    _thread.Start();
                    autoReset.WaitOne();
                }
                else
                {
                    _noticeWindow = new NoticeBoxWindow(animationEase, animationDuration);
                    _noticeWindow.Show();
                }
            }
           var handler = _noticeWindow.AddItem(message, caption, icon, imageIcon, duration, canClose, animationDuration, cardStyle);
            return handler;
        }
        #endregion

    }
}