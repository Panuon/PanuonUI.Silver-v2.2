﻿using System;

namespace Panuon.UI.Silver.Internal.Implements
{
    class NoticeHandlerImpl : INoticeHandler
    {
        #region Fields
        private NoticeBoxItem _noticeBoxItem;
        #endregion

        #region Ctor
        public NoticeHandlerImpl(NoticeBoxItem noticeBoxItem)
        {
            _noticeBoxItem = noticeBoxItem;
        }
        #endregion

        #region Events
        public event EventHandler Clicked;

        public event EventHandler Closed;
        #endregion

        #region Methods
        public void Close()
        {
            _noticeBoxItem.Close();
        }

        public void TriggerClicked(NoticeBoxItem noticeBoxItem)
        {
            Clicked?.Invoke(noticeBoxItem, new EventArgs());
        }

        public void TriggerClosed(NoticeBoxItem noticeBoxItem)
        {
            Closed?.Invoke(noticeBoxItem, new EventArgs());
        }
        #endregion
    }
}