﻿/*
 * Authors:
 *   钟峰(Popeye Zhong) <zongsoft@gmail.com>
 *
 * Copyright (C) 2011-2013 Zongsoft Corporation <http://www.zongsoft.com>
 *
 * This file is part of Zongsoft.CoreLibrary.
 *
 * Zongsoft.CoreLibrary is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * Zongsoft.CoreLibrary is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with Zongsoft.CoreLibrary; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
 */

using System;
using System.ComponentModel;

namespace Zongsoft.Communication
{
	public interface IChannel : IDisposable
	{
		#region 事件定义
		event EventHandler<ChannelEventArgs> Closed;
		event EventHandler<ChannelEventArgs> Closing;
		#endregion

		#region 属性定义
		int ChannelId
		{
			get;
		}

		object Host
		{
			get;
		}

		bool IsIdled
		{
			get;
		}

		DateTime LastSendTime
		{
			get;
		}

		DateTime LastReceivedTime
		{
			get;
		}
		#endregion

		#region 方法定义
		void Close();
		#endregion
	}
}
