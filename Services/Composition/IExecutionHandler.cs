﻿/*
 * Authors:
 *   钟峰(Popeye Zhong) <zongsoft@gmail.com>
 *
 * Copyright (C) 2010-2013 Zongsoft Corporation <http://www.zongsoft.com>
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
using System.Collections.Generic;

namespace Zongsoft.Services.Composition
{
	/// <summary>
	/// 提供执行处理程序的功能。
	/// </summary>
	public interface IExecutionHandler
	{
		/// <summary>
		/// 确认当前处理程序能否处理本次执行请求。
		/// </summary>
		/// <param name="context">当前执行上下文对象。</param>
		/// <returns>如果能处理本次执行请求则返回真(true)，否则返回假(false)。</returns>
		bool CanHandle(IExecutionPipelineContext context);

		/// <summary>
		/// 处理本次执行请求。
		/// </summary>
		/// <param name="context">当前执行上下文对象。</param>
		void Handle(IExecutionPipelineContext context);
	}
}
